namespace ShopRu.Business.Models
{

    public class InvoiceResponse
    {
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
        public string Username { get; set; }
        public string RoleName { get; set; }
    }
}