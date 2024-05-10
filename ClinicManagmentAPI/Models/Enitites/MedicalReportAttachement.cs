using ClinicManagmentAPI.Models.Shared;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalReportAttachement : MainEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public AttachementType AttachementType { get; set; }
        public int? MedicalReportId { get; set; }
    }
}
