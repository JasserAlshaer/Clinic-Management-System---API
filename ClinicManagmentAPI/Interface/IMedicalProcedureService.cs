using ClinicManagementAPI.DTOs.MedicalProcedureServiceDTO;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementAPI.Interface
{
    public interface IMedicalProcedureService
    {
        Task <IActionResult> AddMedicalProcedure(CreateMedicalProcedureDTO dto);
        Task <IActionResult> UpdateMedicalProcedure(UpdateMedicalProcedureDTO dto);
        Task <IActionResult> GetMedicalProcedureById(int id);
        Task <IActionResult> GetAllMedicalProcedure();
        Task <IActionResult> DeleteMedicalProcedure(int id);
    }
}
