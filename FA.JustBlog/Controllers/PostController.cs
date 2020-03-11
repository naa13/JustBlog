using FA.JustBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FA.JustBlog.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository service;
        public PostController()
        {
            service = new PostRepository();
        }
            
        // GET: Post
        public ActionResult Index()
        {
            var listPosts = service.GetAllPosts();
            return View(listPosts);
        }
        public ActionResult Detail()
        {
            return View();
        }
    }
}