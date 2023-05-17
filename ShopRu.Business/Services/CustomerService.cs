using ShopRu.Business.Models;

namespace ShopRu.Business.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {

        }
        public InvoiceResponse GetInvoice(DiscountRequest request)
        {
            var discount = CalculateDiscount(request);
            var response = new InvoiceResponse
            {
                TotalAmount = request.TotalAmount,
                Discount = discount,
                FinalAmount = (request.TotalAmount - discount),
                Username = request.User.Username,
                RoleName = request.User.Role.Name
            };
            return response;
        }
        private decimal CalculateDiscount(DiscountRequest request)
        {
            decimal discount = 0;

            // Apply percentage based discounts
            if (!request.ApplyGroceryDiscount)
            {
                if (request.User.Role.Name == "Employee")
                    discount = request.TotalAmount * 0.3m;
                else if (request.User.Role.Name == "Affiliate")
                    discount = request.TotalAmount * 0.1m;
                else if (request.User.RegisterAt <= DateTime.Now.AddYears(2))
                    discount = request.TotalAmount * 0.05m;
            }

            // Apply amount based discount
            decimal amountBasedDiscount = Math.Floor(request.TotalAmount / 100) * 5m;
            discount += amountBasedDiscount;
            return discount;
        }
    }
}
