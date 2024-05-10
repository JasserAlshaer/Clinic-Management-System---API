namespace ClinicManagmentAPI.DTOs.Users
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string NationalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }
        public string Specialization { get; set; }
        public bool IsHaveDiseases { get; set; }
        public string MedicalStatus { get; set; }
    }
}
