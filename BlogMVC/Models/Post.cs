using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public int CategoriaId { get; set; }
        public DateTime FechaPost { get; set; }


    }


}