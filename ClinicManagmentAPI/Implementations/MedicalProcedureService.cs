using ClinicManagementAPI.DTOs.MedicalProcedureServiceDTO;
using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.Implementations.baseImplementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicalProcedureService : BaseAppService, IMedicalProcedureService
    {
        public MedicalProcedureService(ClinicManagementDbContext context) : base(context)
        {
        }

        public Task<IActionResult> AddMedicalProcedure(CreateMedicalProcedureDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeleteMedicalProcedure(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetMedicalProcedureDTO>> GetAllMedicalProcedure(int medicalReportId)
        {
            var response = from medProc in _context.MedicalProuducres
                           join title in _context.ProcedureTitles
                           on medProc.TitleId equals title.Id
                           where medProc.MedicalReportId == medicalReportId
                           select new GetMedicalProcedureDTO
                           {
                               Title = title.Name,
                               Description = medProc.Description,
                               Price = medProc.Price,
                           };
            return await response.ToListAsync();
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
