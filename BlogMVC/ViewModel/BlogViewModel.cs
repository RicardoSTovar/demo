using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogMVC.Models;


namespace BlogMVC.ViewModel
{
    public class BlogViewModel
    {
        public Post Post { get; set; }
        public List<Categoria> Categoria { get;  set; }

       

    }
}