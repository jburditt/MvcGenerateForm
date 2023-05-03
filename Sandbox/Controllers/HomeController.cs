using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Sandbox.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new FormViewModel();
            model.Name = "Test123";
            model.Code = 1;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(FormViewModel formViewModel)
        {
            var test = formViewModel;

            return View("Index", formViewModel);
        }
    }
}