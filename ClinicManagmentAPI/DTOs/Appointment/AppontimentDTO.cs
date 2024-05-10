namespace ClinicManagmentAPI.DTOs.Appointment
{
    public class AppontimentDTO
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
    }
}
