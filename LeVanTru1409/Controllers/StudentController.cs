using LeVanTru1409.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeVanTru1409.Controllers
{
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            // Khoi tao 1 list student
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
        [HttpPost]
        public IActionResult Create(StudentController1 std)
        {
            // string message = std.StudentID + "-";
            // message += std.StudentName + "-";
            // message += std.Age;
            // ViewBag.TT = message;
            return View();
        }
    }
}
