using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicienList : MainEntity
    {
        public int UserId { get; set; }
        public int MedicienId { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public virtual Medicien Medicien { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
        public virtual User Doctor { get; set; }
    }
}
