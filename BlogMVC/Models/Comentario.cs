using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class Comentario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Texto { get; set; }
        public DateTime fecha { get; set; }
        public int PostId { get; set; }


    }
}