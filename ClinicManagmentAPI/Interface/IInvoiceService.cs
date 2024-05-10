using ClinicManagmentAPI.DTOs.Invoice;using ClinicManagmentAPI.Models.Enitites;using System;namespace ClinicManagementAPI.Interface
{
	public interface IInvoiceService
	{
		Task<List<InvoiceDTO>>GetAllInvoice( );
		Task CreateInvoice(InvoiceCreateDTO dto);		Task UpdatesInvoice(InvoiceUpdateDTO dto);		Task DeleteInvoice(int id);        Task<Invoice> GetInvoice(int id);    }
}

