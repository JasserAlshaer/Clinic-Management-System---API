using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalProuducre : MainEntity
    {
        public int? TitleId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? MedicalReportId { get; set; }
    }
}
