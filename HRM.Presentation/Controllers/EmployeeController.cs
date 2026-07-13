using Microsoft.AspNetCore.Mvc;

namespace HRM.Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
