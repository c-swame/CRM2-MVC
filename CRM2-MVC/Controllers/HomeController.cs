using CRM2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRM2_MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {   
            /*
            LeadModel user = new LeadModel();

            user.Name = "Caio";
            user.Cpf = "123.123.123-23";
            user.Email = "email@email.com";

            return View(user);
            */
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}