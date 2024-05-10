namespace ClinicManagmentAPI.DTOs.Appointment
{
    public class GetAllAppointmentDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
