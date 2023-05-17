using ShopRu.Entities;

namespace ShopRu.Business.Models
{
    public class DiscountRequest
    {
        public decimal TotalAmount { get; set; }
        public bool ApplyGroceryDiscount { get; set; } = false;
        public User User { get; set; }
    }
}