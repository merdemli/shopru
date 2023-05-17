using ShopRu.Business.Models;

namespace ShopRu.Business.Services
{
    public interface ICustomerService
    {

        InvoiceResponse GetInvoice(DiscountRequest request);
    }
}
