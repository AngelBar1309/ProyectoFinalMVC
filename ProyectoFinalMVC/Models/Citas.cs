using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalMVC.Models
{
    public class Citas
    {
        [Key]
        public int citaID { get; set; }

        virtual public  Dentistas dentista { get; set; }

        public int dentistaID { get; set; }

        public DateTime fechaIn { get; set; }

        public DateTime fechaOut { get; set; }

        public double costo { get; set; }

        public string comentarios { get; set; }

        virtual public Dentistas dentistas { get; set; }

        virtual public Clientes clientes { get; set; }

    }
}