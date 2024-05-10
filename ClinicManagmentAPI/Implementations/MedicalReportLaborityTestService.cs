using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.MedicalReprtLaborityTesst;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicalReportLaborityTestService : BaseAppService, IMedicalReportLaborityTestService
    {
        public MedicalReportLaborityTestService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task<IActionResult> CreateMedicalReportLaborityTest(MedicalReportLaborityTestCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> DeleteMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> GetAllMedicalReportLaborityTest()
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> GetMedicalReportLaborityTestById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> UpdateMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
