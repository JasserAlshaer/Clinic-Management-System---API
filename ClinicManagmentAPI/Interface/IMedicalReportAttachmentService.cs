using ClinicManagmentAPI.Models.Enitites;

namespace ClinicManagmentAPI.Interface
{
    public interface IMedicalReportAttachmentService
    {
        Task<MedicalReportAttachement> GetReportAttachementById(int Id);
        bool CreatrMedicalReportAttachement();
        bool UpdateMedicalReportAttachement();
        bool DeletMedicalReportAttachement();

    }
}
