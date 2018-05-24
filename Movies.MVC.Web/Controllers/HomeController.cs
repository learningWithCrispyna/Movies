using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Movies.MVC.Web.Models;

namespace Movies.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HelloWorldModel();
            model.PageContext = "hello World";
            return View(model);
        }
    }
}
