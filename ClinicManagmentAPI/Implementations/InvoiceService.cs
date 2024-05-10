using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.Invoice;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI.Implementations
{
    public class InvoiceService : BaseAppService, IInvoiceService
    {
        public InvoiceService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task CreateInvoice(InvoiceCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteInvoice(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InvoiceDTO>> GetAllInvoice()
        {
            throw new NotImplementedException();
        }

        public async Task<Invoice> GetInvoice(int Id)
        {
            //Single Or Default (Ensure that there is only one object as result of query)
            var invoice = await _context.Invoices.SingleOrDefaultAsync(x => x.Id == Id);
            if(invoice == null)
                throw new Exception(ExceptionsConstant.InvoiceNotExisit);
            return invoice;
        }

        public async Task UpdatesInvoice(InvoiceUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
