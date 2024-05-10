using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class Appointment : MainEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }

    }
}
