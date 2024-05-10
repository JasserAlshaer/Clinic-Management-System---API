using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.DTOs.MedicalReprtLaborityTesst
{
    public class MedicalReportLaborityTestCreateDTO
    {
        public int MedicalReportId { get; set; }
        public Servity Servity { get; set; }
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatorUserId { get; set; }
        public int ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
