using Microsoft.AspNetCore.Mvc;
using ShopRu.Business.Models;
using ShopRu.Business.Services;

namespace ShopRu.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountsController : ControllerBase
    {
        readonly ICustomerService _customerService;
        public DiscountsController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("calculate")]
        public ActionResult<InvoiceResponse> GetInvoice(DiscountRequest request)
        {
            var response = _customerService.GetInvoice(request);
            return Ok(response);
        }
    }
}