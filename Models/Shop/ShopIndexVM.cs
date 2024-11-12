using Zay_Template.Models.Home;
using Zay_Template.Models.Shop;

namespace Zay_Template.Models.Category
{
    public class ShopIndexVM
    {
        public List<CategoryVM> Categories { get; set; }
        public List<ProductVM> Products { get; set; }

    }
}
