using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicienList : MainEntity
    {
        public int MedicienId { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public int? MedicalReportId { get; set; }
    }
}
