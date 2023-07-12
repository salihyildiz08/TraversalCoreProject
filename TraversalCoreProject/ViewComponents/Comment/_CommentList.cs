using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal(new Context()));
        public IViewComponentResult Invoke(int id)
        {
            var values=commentManager.TGetListFilter(id);
            return View(values);
        }
    }
}
