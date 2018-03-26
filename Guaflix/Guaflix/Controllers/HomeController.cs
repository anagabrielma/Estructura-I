using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guaflix.Models;
using Guaflix.Data;
using Guaflix.Controllers;
using System.IO; 


namespace Guaflix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(FormCollection persona)
        {

            try
            {
                var model = new Username
                {
                    Nombre = persona["Nombre"],
                    Apellido = persona["Apellido"],
                    Edad = Convert.ToInt16(persona["Edad"]),
                    Usuarios = persona["Usuarios"],
                    Password = persona["Password"]
                };

                Persona.Instance.usuarios.Add((model));
                return RedirectToAction("Login");
            }
            catch
            {
                return RedirectToAction("Login", "Home");

            }
        }
    
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string password, string username)
        {
            if (username == "admin" && password == "admin")
            {
                return RedirectToAction("Contact", "home");
            }
            foreach (var model in Data.Persona.Instance.usuarios)
            { 
                if(username == model.Usuarios && password == model.Usuarios)
                {
                    return RedirectToAction("Contact", "home");
                }
            }
            return View();
        }
    }
}