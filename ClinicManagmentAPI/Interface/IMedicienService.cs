using ClinicManagementAPI.DTOs.MedicienDTO;
using ClinicManagmentAPI.DTOs.MedicienDTO;
using ClinicManagmentAPI.Models.Enitites;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementAPI.Interface
{
    public interface IMedicienService
    {
        Task<Medicien> GetMedicienById(int Id);
        Task<List<Medicien>> GetAllMedicien();
        Task<IActionResult> CreateMedicien(CreateMedicienDTO dto);
        Task<IActionResult> UpdateMedicien(UpdateMedicienDTO dto);
        Task<IActionResult> DeleteMedicien(int Id);
    }
}
