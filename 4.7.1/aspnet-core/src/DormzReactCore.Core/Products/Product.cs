using Abp.Domain.Entities;

namespace DormzReactCore.Products {
    public class Product : Entity<int> {
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
