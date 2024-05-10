using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalReportAttachement : MainEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public AttachementType AttachementType { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }
    }
}
