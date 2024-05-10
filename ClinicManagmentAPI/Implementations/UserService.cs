using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.Users;
using ClinicManagmentAPI.Implementations.baseImplementation;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ClinicManagmentAPI.Implementations
{
    public class UserService : BaseAppService, IUserService
    {
        public UserService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task CreateUser(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserProfileDto>> GetAllUsers()
        {
            //Memeory Execation 
            /*var result = from user in await _context.Users.ToListAsync()
                         orderby user.CreationDate descending
                         select new UserProfileDto
                         {
                             Id = user.Id,
                             NationalId = user.NationalId,
                             Name = user.Name,
                             Email = user.Email,
                             Phone = user.Phone,
                             ProfileImage = user.ProfileImage,
                             Specialization = user.Specialization,
                             IsHaveDiseases = user.IsHaveDiseases,
                             MedicalStatus = user.MedicalStatus
                         };
            return result.ToList();*/
            //Get In Quarriable 
            var result = from user in _context.Users
                          orderby user.CreationDate descending
                          select new UserProfileDto
                          {
                              Id = user.Id,
                              NationalId = user.NationalId,
                              Name = user.Name,
                              Email = user.Email,
                              Phone = user.Phone,
                              ProfileImage = user.ProfileImage,
                              Specialization = user.Specialization,
                              IsHaveDiseases = user.IsHaveDiseases,
                              MedicalStatus = user.MedicalStatus
                          };
             return await result.ToListAsync();
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
