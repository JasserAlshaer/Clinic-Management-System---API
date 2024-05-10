using ClinicManagementAPI.DTOs.MedicienDTO;
using ClinicManagmentAPI.DTOs.MedicienDTO;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementAPI.Interface
{
    public interface IMedicienService
    {
        Task<IActionResult> GetMedicienById(int Id);
        Task<IActionResult> GetAllMedicien();
        Task<IActionResult> CreateMedicien(CreateMedicienDTO dto);
        Task<IActionResult> UpdateMedicien(UpdateMedicienDTO dto);
        Task<IActionResult> DeleteMedicien(int Id);
    }
}
