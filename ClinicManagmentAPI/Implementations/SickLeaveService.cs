using ClinicManagementAPI.DTO.SickLeaveDTO;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI.Models.Enitites;
using ClinicManagmentAPI_Repos.DTO.SickLeaveDTO;

namespace ClinicManagmentAPI.Implementations
{
    public class SickLeaveService : ISickLeaveService
    {
        public async Task<int> CreateSickLeave(CreateSickLeaveDTO dTO)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteSickLeave(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SickLeaveDTOCard>> GetAllSickLeave()
        {
            throw new NotImplementedException();
        }

        public async Task<SickLeave> GetSickLeaveById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateSickLeave(UpdateSickLeaveDTO dTO)
        {
            throw new NotImplementedException();
        }
    }
}
