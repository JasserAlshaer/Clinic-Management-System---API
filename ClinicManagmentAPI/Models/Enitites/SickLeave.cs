using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class SickLeave : MainEntity
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Recommendations { get; set; }
        public string Reason { get; set; }
        public  int? MedicalReportId { get; set; }
    }
}
