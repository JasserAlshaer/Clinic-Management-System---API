using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalReport : MainEntity
    {
        public DateTime Date { get; set; }
        public CaseType CaseType { get; set; }
        public string MainDescription { get; set; }
        public string Diagnosis { get; set; }
        public virtual User User { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }
    }
}
