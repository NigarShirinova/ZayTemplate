using Microsoft.AspNetCore.Mvc;

namespace Zay_Template.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
