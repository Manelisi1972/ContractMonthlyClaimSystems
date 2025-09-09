using System.Diagnostics;
using ContractMonthlyClaimSystems.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystems.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
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

    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View(); // List of claims
        }

        public IActionResult Create()
        {
            return View(); // Submit new claim
        }

        public IActionResult Details(int id)
        {
            return View(); // Claim details + status
        }

        public IActionResult Upload()
        {
            return View(); // Upload documents
        }
    }

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Coordinator/Manager dashboard
        }
    }


}
