using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class Appointment : MainEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public AppointmentStatus Status { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DoctorId { get; set; }

    }
}
