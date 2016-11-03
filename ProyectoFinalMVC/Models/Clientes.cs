﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace ProyectoFinalMVC.Models
{
    public class Clientes
    {
        [Key]
        public int clienteID { get; set; }

        public string nombre { get; set; }

        public string apellidoP { get; set; }
        
        public string apellidoM { get; set; }

        public string direccion { get; set; }

        public int telefono { get; set; }







    }
}