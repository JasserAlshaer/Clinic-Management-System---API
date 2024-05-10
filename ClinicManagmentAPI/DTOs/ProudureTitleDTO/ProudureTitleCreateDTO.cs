namespace ClinicManagmentAPI.DTOs.ProudureTitleDTO
{
    public class ProudureTitleCreateDTO
    {

        public string name { get; set; }

        public DateTime CreationDate { get; set; }= DateTime.Now;
    
        public bool IsDeleted { get; set; }




    }
}
