using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogMVC.Models
{
    public class BlogContext : DbContext
    {

        public DbSet<Post> Post { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

    }
}