using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.DTOs.Invoice
{
    public class InvoiceDTO
    {
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public DiscountType DiscountType { get; set; }
        public double DiscountAmount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string DiscountReason { get; set; }
        public string NameUser { get; set; }
        public string NameEmployee { get; set; }
        public string NameDoctor { get; set; }

    }
}
