using ClinicManagementAPI.DTOs.MedicienListDTO;
using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.DTOs.MedicienListDTO;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicienListService : IMedicienListService
    {
        public async Task CreateNewMedicineList(CreateMedicienListDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMedicineList(UpdateMedicienListDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MedicienListDetailsDTO>> GetMedicineListDetailsByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MedicienListInformationDTO>> GetMedicineListInfoByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMedicineList(UpdateMedicienListDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
