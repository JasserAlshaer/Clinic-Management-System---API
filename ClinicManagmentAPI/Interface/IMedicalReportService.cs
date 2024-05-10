namespace ClinicManagementAPI.Interface
{
    public interface IMedicalReportService
    {
        // Method to get all medical reports
        Task<List<GetMedicalReportDTO>> GetAllMedicalReports(int? userId = null);
        // Method to get a medical report by its ID
        Task<GetMedicalReportDTO> GetMedicalReportById(int Id);
        // Method to create a new medical report
        Task CreateMedicalReport(CreateMedicalReportDTO dto);

        // Method to update an existing medical report
        Task UpdateMedicalReport(int id, UpdateMedicalReportDTO dto);
        // Method to delete a medical report
        Task DeleteMedicalReport(int id,UpdateMedicalReportDTO dto);
    }
}
