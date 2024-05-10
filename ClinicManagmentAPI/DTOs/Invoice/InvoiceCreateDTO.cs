using ClinicManagmentAPI.Models.Enitites;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.DTOs.Invoice
{
    public class InvoiceCreateDTO
    {
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DiscountType DiscountType { get; set; }
        public double DiscountAmount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string DiscountReason { get; set; }
        public int User { get; set; }
        public int Employee { get; set; }
        public int Doctor { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int CreatorUser { get; set; }

    }
}
