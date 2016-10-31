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

        public DateTime fechaFinal { get; set; }

        public int confirmacionID { get; set; }

        public virtual Confirmacion confirmacion { get; set; }

    }
}