using LeVanTru1409.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeVanTru1409.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> StdList = new List<Student>()
            {
                new Student {StudentID = 1, StudentName = "Sinh Vien A", StudentAge = 18 },
                new Student {StudentID = 2, StudentName = "Sinh Vien B", StudentAge = 17 },
                new Student {StudentID = 3, StudentName = "Sinh Vien C", StudentAge = 21 },
                new Student {StudentID = 4, StudentName = "Sinh Vien D", StudentAge = 18 },
                new Student {StudentID = 5, StudentName = "Sinh Vien E", StudentAge = 22 },
            };
            ViewData["Students"] = StdList;
      
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