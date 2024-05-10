using ClinicManagmentAPI.Models.Enitites;

namespace ClinicManagmentAPI.Models.Shared
{
    public class MainEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual User CreatorUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public bool IsDeleted { get; set; }


    }
}
