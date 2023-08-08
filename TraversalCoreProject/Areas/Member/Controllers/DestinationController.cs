using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly DestinationManager _destinationManager=new DestinationManager(new EfDestinationDal(new Context()));


        public IActionResult Index()
        {
            var values = _destinationManager.TGetList();

            return View(values);
        }
    }
}
