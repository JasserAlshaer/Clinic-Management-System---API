namespace ClinicManagementAPI.DTO.SickLeaveDTO
{
    public class UpdateSickLeaveDTO
    {
        public int Id { get; set; } 
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Recommendations { get; set; }
        public string Reason { get; set; }
    }
}
