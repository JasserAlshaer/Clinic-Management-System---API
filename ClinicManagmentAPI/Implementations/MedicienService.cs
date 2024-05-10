using ClinicManagementAPI.DTOs.MedicienDTO;
using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.MedicienDTO;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Models.Enitites;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicienService : BaseAppService, IMedicienService
    {
        public MedicienService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task<IActionResult> CreateMedicien(CreateMedicienDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> DeleteMedicien(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Medicien>> GetAllMedicien()
        {
            throw new NotImplementedException();
        }

        public async Task<Medicien> GetMedicienById(int Id)
        {
            var responese = await _context.Mediciens.FindAsync(Id);
            if (responese == null)
                throw new Exception(ExceptionsConstant.MediciennNotExisit);
            return responese;
        }

        public async Task<IActionResult> UpdateMedicien(UpdateMedicienDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
