using Microsoft.AspNetCore.Mvc;
using Zay_Template.Data;
using Zay_Template.Entities;
using Zay_Template.Models.Category;
using Zay_Template.Models.Home;

namespace Zay_Template.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            var categoriesList = new List<CategoryVM>();
            foreach (var category in categories)
            {
                var categoryVM = new CategoryVM
                {
                    Name = category.Name,
                };

                categoriesList.Add(categoryVM);
            }

            var model = new ShopIndexVM
            {
                Categories = categoriesList
            };



            return View(model);
        }
    }
}
