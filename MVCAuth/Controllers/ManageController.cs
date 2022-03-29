using Microsoft.AspNetCore.Mvc;

namespace MVCAuth.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
