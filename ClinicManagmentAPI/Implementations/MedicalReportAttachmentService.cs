using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Interface;
using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI.Implementations
{
    public class MedicalReportAttachmentService : BaseAppService, IMedicalReportAttachmentService
    {
        public MedicalReportAttachmentService(ClinicManagementDbContext context) : base(context)
        {
        }


        public async Task<MedicalReportAttachement> GetReportAttachementById(int Id)
        {
            var response  = from attach in _context.MedicalReportAttachements
                            where attach.Id == Id
                            select attach;
            var query = await response.SingleOrDefaultAsync();
            if(query != null)
                return query;
            throw new Exception(ExceptionsConstant.AttachmentNotExisit);
        }

        public bool CreatrMedicalReportAttachement()
        {
            throw new NotImplementedException();
        }

        public bool DeletMedicalReportAttachement()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMedicalReportAttachement()
        {
            throw new NotImplementedException();
        }
    }
}
