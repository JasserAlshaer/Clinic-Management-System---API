using ClinicManagementAPI.DTOs.MedicienListDTO;
using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.MedicienListDTO;
using ClinicManagmentAPI.Implementations.baseImplementation;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicienListService : BaseAppService, IMedicienListService
    {
        public MedicienListService(ClinicManagementDbContext context) : base(context)
        {
        }

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
