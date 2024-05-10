using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class Appointment : MainEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DoctorId { get; set; }

    }
}
