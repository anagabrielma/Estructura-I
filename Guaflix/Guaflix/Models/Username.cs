using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Guaflix.Models
{
    public class Username
    {
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El Edad es requerido")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El Usuario es requerido")]
        public string Usuarios { get; set; }
        [Required(ErrorMessage = "El Password es requerido")]
        public string Password { get; set; }
    }
}