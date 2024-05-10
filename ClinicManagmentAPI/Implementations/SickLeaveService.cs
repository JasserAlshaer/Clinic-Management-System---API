using ClinicManagementAPI.DTO.SickLeaveDTO;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI.Models.Enitites;
using ClinicManagmentAPI_Repos.DTO.SickLeaveDTO;

namespace ClinicManagmentAPI.Implementations
{
    public class SickLeaveService : BaseAppService, ISickLeaveService
    {
        public SickLeaveService(ClinicManagementDbContext context) : base(context)
        {
        }

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
