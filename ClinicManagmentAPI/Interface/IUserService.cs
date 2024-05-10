
using ClinicManagmentAPI.DTOs.Users;

namespace ClinicManagementAPI.Interface
{
    public interface IUserService
    {
        Task<UserProfileDto> GetUserProfile(int userId);

        Task<IEnumerable<UserProfileDto>> GetAllUsers();

        Task CreateUser(CreateUserDto createUserDto);

        Task UpdateUser(UpdateUserDto updateUserDto);       
    }
}
