using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalReportLaborityTest : MainEntity
    {
        public virtual LaborityTest LaborityTest { get; set; }
        public int MedicalReportId { get; set; }
        public Servity Servity { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
        public virtual User Doctor { get; set; }
        public string TestResult { get; set; }
        public string SampleType { get; set; }
        public int NumberOfTests { get; set; }
        public string TechnicianName { get; set; }

    }
}
