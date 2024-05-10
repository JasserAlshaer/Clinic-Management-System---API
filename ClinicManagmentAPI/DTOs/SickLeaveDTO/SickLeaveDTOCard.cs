using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI_Repos.DTO.SickLeaveDTO
{
    public class SickLeaveDTOCard
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Recommendations { get; set; }
        public string Reason { get; set; }


    }
}
