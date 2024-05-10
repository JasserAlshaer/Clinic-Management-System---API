using ClinicManagementAPI.DTOs.MedicienListDTO;
using ClinicManagmentAPI.DTOs.MedicienListDTO;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagementAPI.Interface
{
    public interface IMedicienListService
    {
        //Create New Medicine List
        Task CreateNewMedicineList(CreateMedicienListDTO dto);
        //Get Medicine List Details by UserID
        Task<List<MedicienListDetailsDTO>> GetMedicineListDetailsByUserID(int userID);
        //Get Medicine List Info by UserID
        Task<List<MedicienListInformationDTO>> GetMedicineListInfoByUserID(int userID);
        //Update Medicine List
        Task UpdateMedicineList(UpdateMedicienListDTO dto);
        //Delete Medicine List
        Task DeleteMedicineList(UpdateMedicienListDTO dto);
        
    }
}
