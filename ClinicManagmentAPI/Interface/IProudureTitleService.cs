
using ClinicManagmentAPI.DTOs.ProudureTitleDTO;


namespace ClinicManagmentAPI.Interface
{
    public interface IProudureTitleService
    {

        Task<List<ProudureTitleCard>> GetAllIProudureTitle();
        Task CreateIProudureTitle(ProudureTitleCreateDTO dto);
        Task UpdateIProudureTitle(ProudureTitleUpdate dto);
        Task DeleteIProudureTitle(int id);
        Task<ProudureTitleCard> GetIProudureTitle(int id);


    }
}
