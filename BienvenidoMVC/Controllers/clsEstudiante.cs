﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BienvenidoMVC.Controllers
{
    public class clsEstudiante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Carrera { get; set; }
    }
}