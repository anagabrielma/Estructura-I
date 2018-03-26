using Guaflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guaflix.Data
{
    public class Persona
    {
        private static Persona instance;
        public static Persona Instance
        {
            get
            {
                if (instance == null) instance = new Persona();
                return instance;
            }
        }
        public List<Username> usuarios;
        public Persona()
        {
            usuarios = new List<Username>();
            
        }
    }
}