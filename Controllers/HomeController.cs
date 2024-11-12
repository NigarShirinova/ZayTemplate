using Microsoft.AspNetCore.Mvc;
using Zay_Template.Data;
using Zay_Template.Models.Home;

namespace Zay_Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sliders = _context.Sliders.OrderBy(x => x.Id).Take(3).ToList();

            var slidersList = new List<SliderVM>();
            foreach (var slider in sliders)
            {
                var sliderVM = new SliderVM
                {
                    FirstName = slider.FirstName,
                    SecondName = slider.SecondName,
                    Description = slider.Description,
                    PhotoPath = slider.PhotoPath
                 
                };

                slidersList.Add(sliderVM);
            }

            var model = new HomeIndexVM
            {
                Sliders = slidersList
            };

            return View(model);
        }
    }
}
