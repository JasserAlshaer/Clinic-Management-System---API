namespace ClinicManagmentAPI.DTOs.Appointment
{
    public class UpdateAppoitmentDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }

    }
}
