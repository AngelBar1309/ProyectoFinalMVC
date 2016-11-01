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

        public DateTime fechaIn { get; set; }

        public DateTime fechaOn { get; set; }

        public int dentistaID { get; set; }

        virtual public Dentistas dentista { get; set; }

        virtual public Citas citas { get; set; }





    }
}