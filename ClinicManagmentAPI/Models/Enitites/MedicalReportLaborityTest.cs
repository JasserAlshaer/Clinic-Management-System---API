using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalReportLaborityTest : MainEntity
    {
        public int? LaborityTestId { get; set; }
        public int MedicalReportId { get; set; }
        public Servity Servity { get; set; }
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }

    }
}
