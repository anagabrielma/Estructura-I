﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB1_ANA_EDWIN.Models
{
    public class Jugador
    {
        public string Club { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string Posicion { get; set; }
        public string Salario { get; set; }

        public string Compensaciones { get; set; }
    }
}