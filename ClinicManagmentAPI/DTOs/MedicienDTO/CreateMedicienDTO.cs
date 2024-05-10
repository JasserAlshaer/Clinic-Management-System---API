namespace ClinicManagmentAPI.DTOs.MedicienDTO
{
    public class CreateMedicienDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUser { get; set; }

    }
}
