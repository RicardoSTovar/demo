using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogMVC.Models;

namespace BlogMVC.ViewModel
{
    public class PostComentarioVM
    {
        public Post post { get; set; }
        public List<Comentario> comentario { get; set; }


    }
}