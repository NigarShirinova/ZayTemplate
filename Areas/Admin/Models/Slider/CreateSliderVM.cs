using System.ComponentModel.DataAnnotations;

namespace Zay_Template.Areas.Admin.Models.Slider
{
    public class CreateSliderVM
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Second name is required")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Photo path is required")]
        public string PhotoPath { get; set; }
    }
}
