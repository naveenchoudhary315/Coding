using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CusotomController : Controller
    {
        // Add basic api method and versioning cases.
        public IActionResult Index()
        {
            return View();
        }
    }
}
