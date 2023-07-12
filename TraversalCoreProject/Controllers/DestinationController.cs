using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal(new Context()));
        public IActionResult Index()
        {
            var values = _destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult  Details(int id)
        {
            var value = _destinationManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Details(Destination p)
        {
            return View();
        }
    }
}
