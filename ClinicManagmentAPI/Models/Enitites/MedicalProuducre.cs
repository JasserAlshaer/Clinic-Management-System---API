using ClinicManagmentAPI.Models.Shared;

namespace ClinicManagmentAPI.Models.Enitites
{
    public class MedicalProuducre : MainEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual MedicalReport MedicalReport { get; set; }
        public virtual User Employee { get; set; }
        public virtual User Doctor { get; set; }
    }
}
