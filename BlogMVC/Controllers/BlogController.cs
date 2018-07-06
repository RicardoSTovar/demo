using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMVC.Models;
using BlogMVC.ViewModel;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            var posts = from e in db.Post
                              orderby e.Id
                              select e;
            
            return View(posts.ToList());
        }

        public ActionResult Edit(int Id)
        {
                //var post = db.Post.Single(m => m.Id == Id);
                //return View(post);

            BlogViewModel blogViewModel = new BlogViewModel();

            blogViewModel.Categoria = (from e in db.Categoria
                                       orderby e.Id
                                       select e).ToList();
            blogViewModel.Post = db.Post.Single(m => m.Id == Id);

            return View(blogViewModel);
        }

        [HttpPost]
        public ActionResult Edit(int Id, FormCollection collection)
        {
            try
            {
              var post = db.Post.Single(m => m.Id == Id);
                    if (TryUpdateModel(post))
                    {
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                return View(post);
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Create()
        {
            BlogViewModel blogViewModel = new BlogViewModel();

            blogViewModel.Categoria = (from e in db.Categoria
                                  orderby e.Id
                                  select e).ToList();

            return View(blogViewModel);
        }


        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                // TODO: Add insert logic here

                db.Post.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int Id)
        {
            Post post = db.Post.First(s => s.Id == Id);
            return View(post);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            Post studentToRemove = db.Post.First(s => s.Id == post.Id);
            db.Post.Remove(studentToRemove);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Leer(int Id)
        {
            
            PostComentarioVM postComentarioVM = new PostComentarioVM();

            postComentarioVM.post = db.Post.Single(m => m.Id == Id);

            postComentarioVM.comentario= (from e in db.Comentario
                                          orderby e.Id
                                          where e.PostId==Id
                                          select e).ToList();

            return View(postComentarioVM);
        }

        [HttpPost]
        public ActionResult Leer(Comentario comentario)
        {
            db.Comentario.Add(comentario);
            db.SaveChanges();
            return View();
        }

    }
}