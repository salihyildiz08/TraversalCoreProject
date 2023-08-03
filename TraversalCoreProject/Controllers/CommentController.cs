using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager=new CommentManager(new EfCommentDal(new Context()));
        
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.State = true;
            commentManager.TAdd(p);

            return RedirectToAction("Index","Destination");
        }
        
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
    }
}
