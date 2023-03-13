using System.ComponentModel.DataAnnotations;

namespace eshop.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün Adı boş olamaz!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public double DiscountRate { get; set; }

    }
}
