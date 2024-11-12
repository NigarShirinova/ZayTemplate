using Microsoft.AspNetCore.Mvc;
using Zay_Template.Areas.Admin.Models.Slider;
using Zay_Template.Data;
using Zay_Template.Entities;

namespace Zay_Template.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        #region List

        [HttpGet]
        public IActionResult Index()
        {
            var model = new SliderIndexVM
            {
                Sliders = _context.Sliders.ToList()
            };
            return View(model);
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateSliderVM model)
        {
            //if (!ModelState.IsValid) return View();

            var slider = new Slider
            {
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                Description = model.Description,
                PhotoPath = model.PhotoPath,
                
            };

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion


        #region Update

        [HttpGet]
        public IActionResult Update(int id)
        {
            var slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();

            var model = new UpdateSliderVM
            {
                Id = slider.Id,
                FirstName = slider.FirstName,
                SecondName = slider.SecondName,
                Description = slider.Description,
                PhotoPath = slider.PhotoPath
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UpdateSliderVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var slider = _context.Sliders.Find(model.Id);
            if (slider == null) return NotFound();

            slider.FirstName = model.FirstName;
            slider.SecondName = model.SecondName;
            slider.Description = model.Description;
            slider.PhotoPath = model.PhotoPath;

            _context.Sliders.Update(slider);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Delete

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();

            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        #endregion


    }
}
