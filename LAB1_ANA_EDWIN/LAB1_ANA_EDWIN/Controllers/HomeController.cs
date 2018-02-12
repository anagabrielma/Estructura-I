using System;
using LAB1_ANA_EDWIN.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using directorios = System.IO;

namespace LAB1_ANA_EDWIN.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View (new List<Models.Jugador>());
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase archivoBase)
        {
            List<Models.Jugador> jugadores = new List<Models.Jugador>();
            string pathArchivo = string.Empty;
            if (archivoBase != null)
            {
                string path = Server.MapPath("~/Cargas/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                pathArchivo = path + Path.GetFileName(archivoBase.FileName);
                string extension = Path.GetExtension(archivoBase.FileName);
                archivoBase.SaveAs(pathArchivo);
                Random miRandom = new Random();
                string archivoCsv = directorios.File.ReadAllText(pathArchivo);
                foreach (string lineas in archivoCsv.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(lineas))
                    {
                        jugadores.Add(new Models.Jugador
                        {
                            Club = Convert.ToString(lineas.Split(',')[0]),
                            Apellido = Convert.ToString(lineas.Split(',')[1]),
                            Nombre = Convert.ToString(lineas.Split(',')[2]),
                            Posicion = Convert.ToString(lineas.Split(',')[3]),
                            Salario = (lineas.Split(',')[4]),
                            Compensaciones = (lineas.Split(',')[5])
                        });
                    }
                }
            }
           return View(jugadores);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}