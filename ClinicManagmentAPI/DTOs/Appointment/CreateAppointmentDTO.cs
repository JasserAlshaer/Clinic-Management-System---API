namespace ClinicManagmentAPI.DTOs.Appointment
{
    public class CreateAppointmentDTO
    {
        public DateTime CreationDate { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
