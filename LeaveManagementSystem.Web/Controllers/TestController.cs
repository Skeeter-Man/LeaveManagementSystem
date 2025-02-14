using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var date = new TestViewModel
            {
                Name = "Student",
                DateOfBirth= DateTime.Now
            };
            return View(date);
        }
    }
}
