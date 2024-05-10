namespace ClinicManagmentAPI.DTOs.MedicienListDTO
{
    public class CreateMedicienListDTO
    {
        public int UserId { get; set; }
        public int MedicienId { get; set; }
        public int QTN { get; set; }
        public int Dose { get; set; }
        public int PerHour { get; set; }
        public int CreatorUser { get; set; }
    }
}
