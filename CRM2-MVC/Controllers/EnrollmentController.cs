using Microsoft.AspNetCore.Mvc;

namespace CRM2_MVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
