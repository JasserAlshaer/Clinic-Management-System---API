using ClinicManagmentAPI.Models.Enitites;

namespace ClinicManagmentAPI.Models.Shared
{
    public class MainEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public  int CreatorUserId { get; set; }
        public  int ModifiedUserId { get; set; }
        public bool IsDeleted { get; set; }


    }
}
