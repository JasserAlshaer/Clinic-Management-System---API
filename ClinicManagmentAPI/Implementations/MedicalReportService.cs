using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.Implementations.baseImplementation;
using Microsoft.EntityFrameworkCore;
using static ClinicManagmentAPI.Helper.Enums.SystemEnums;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicalReportService : BaseAppService, IMedicalReportService
    {
        public MedicalReportService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task CreateMedicalReport(CreateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMedicalReport(int id, UpdateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetMedicalReportDTO>> GetAllMedicalReports(int? userId = null)
        {
            bool adminFlag = userId == null ? true : false;
            var response = from report in _context.MedicalReports
                           join patient in _context.Users
                           on report.UserId equals patient.Id
                           join employee in _context.Users
                           on report.UserId equals employee.Id
                           join doctor in _context.Users
                           on report.UserId equals doctor.Id
                           where report.UserId == userId
                           || report.DoctorId == userId
                           || report.EmployeeId == userId
                           || adminFlag
                           orderby report.CreationDate descending
                           select new GetMedicalReportDTO
                           {
                               Id = report.Id,
                               CreationDate = report.CreationDate,
                               CaseType = report.CaseType.ToString(),
                               MainDescription = report.MainDescription,
                               Diagnosis = report.Diagnosis,
                               PatientName = patient.Name,
                               PatientNationalId = patient.NationalId,
                               PatientPhone = patient.Phone,
                               PatientEmail = patient.Email,
                               EmployeeName = employee.Name,
                               DoctorName = doctor.Name,
                               PatientImage = doctor.ProfileImage
                           };
            return await response.ToListAsync();
        }

        public async Task<GetMedicalReportDTO> GetMedicalReportById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMedicalReport(int id, UpdateMedicalReportDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
