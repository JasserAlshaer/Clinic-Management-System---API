using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.DTOs.Users;

namespace ClinicManagmentAPI.Implementations
{
    public class UserService : IUserService
    {
        public async Task CreateUser(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserProfileDto>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<UserProfileDto> GetUserProfile(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
