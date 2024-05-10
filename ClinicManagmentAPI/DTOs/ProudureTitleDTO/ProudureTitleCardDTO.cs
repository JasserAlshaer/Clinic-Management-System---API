namespace ClinicManagmentAPI.DTOs.ProudureTitleDTO
{
    public class ProudureTitleCard
    {

        public int Id { get; set; }
        public string name { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }





    }
}
