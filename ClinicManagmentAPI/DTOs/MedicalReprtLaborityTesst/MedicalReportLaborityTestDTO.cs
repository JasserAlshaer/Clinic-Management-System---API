using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI_Repos.DTOs.MedicalReprtLaborityTesst
{
    public class MedicalReportLaborityTestDTO
    {
        public  string LaborityTest { get; set; }
        public Servity Servity { get; set; }
        public string MedicalReport { get; set; }
        public string Doctor { get; set; }
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }
    }
}
