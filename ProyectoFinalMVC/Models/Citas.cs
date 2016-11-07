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

        public bool Confirmacion { get; set; }

        public String Comentario { get; set; }

        virtual public ICollection<Dentistas> dentista { get; set; }

        virtual public ICollection<Clientes> cliente
        {
            get;
            set;
        }





    }
}