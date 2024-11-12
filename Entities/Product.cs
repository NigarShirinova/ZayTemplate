namespace Zay_Template.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
        public int CategoryId { get; set; }
    }
}
