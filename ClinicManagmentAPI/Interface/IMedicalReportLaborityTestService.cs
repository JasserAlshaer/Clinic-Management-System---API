using ClinicManagmentAPI.DTOs.MedicalReprtLaborityTesst;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagmentAPI.Interface
{
    public interface IMedicalReportLaborityTestService
    {
        Task<IActionResult> GetAllMedicalReportLaborityTest();
        Task<IActionResult> GetMedicalReportLaborityTestById(int Id);
        Task<IActionResult> CreateMedicalReportLaborityTest(MedicalReportLaborityTestCreateDTO dto);
        Task<IActionResult> UpdateMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto);
        Task<IActionResult> DeleteMedicalReportLaborityTest(MedicalReportLaborityTestUpdateDTO dto);
    }
}
