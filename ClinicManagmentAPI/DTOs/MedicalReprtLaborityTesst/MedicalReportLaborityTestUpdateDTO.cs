using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.DTOs.MedicalReprtLaborityTesst
{
    public class MedicalReportLaborityTestUpdateDTO
    {
        public Servity Servity { get; set; }
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
