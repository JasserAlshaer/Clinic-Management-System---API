using ClinicManagementAPI.DTO.SickLeaveDTO;
using ClinicManagmentAPI.Models.Enitites;
using ClinicManagmentAPI_Repos.DTO.SickLeaveDTO;

namespace ClinicManagmentAPI.Interface
{
    public interface ISickLeaveService
    {
        Task<int> CreateSickLeave(CreateSickLeaveDTO dTO);
        Task<SickLeave> GetSickLeaveById(int id);
        Task<List<SickLeaveDTOCard>> GetAllSickLeave();
        Task UpdateSickLeave(UpdateSickLeaveDTO dTO);
        Task DeleteSickLeave(int id);

    }
}
