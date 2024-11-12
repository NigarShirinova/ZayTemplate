using Microsoft.AspNetCore.Mvc;

namespace Zay_Template.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
