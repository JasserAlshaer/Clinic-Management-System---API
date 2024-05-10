using ClinicManagementAPI.DTOs.MedicalProcedureServiceDTO;
using ClinicManagementAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicalProcedureService : IMedicalProcedureService
    {
        public Task<IActionResult> AddMedicalProcedure(CreateMedicalProcedureDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteMedicalProcedure(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetAllMedicalProcedure()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> GetMedicalProcedureById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> UpdateMedicalProcedure(UpdateMedicalProcedureDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
