using SportsStore.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models.ProductViewModels {
    public class EditViewModel {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "In stock")]
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public Availability Availability { get; set; }

        public EditViewModel() {
            InStock = true;
        }

        public EditViewModel(Product product) {
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            InStock = product.InStock;
            CategoryId = product.Category?.CategoryId ?? 0;
            Availability = product.Availability;
        }
    }
}
