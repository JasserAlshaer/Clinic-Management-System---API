using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class Invoice : MainEntity
    {
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public DiscountType DiscountType { get; set; }
        public double DiscountAmount { get; set; }
        public double PriceAfterDiscount { get; set; }
        public string DiscountReason { get; set; }
        public virtual User User { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }
    }
}
