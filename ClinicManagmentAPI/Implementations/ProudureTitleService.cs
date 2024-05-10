using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.ProudureTitleDTO;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations.baseImplementation;
using ClinicManagmentAPI.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI.Implementations
{
    public class ProudureTitleService : BaseAppService, IProudureTitleService
    {
        public ProudureTitleService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task CreateIProudureTitle(ProudureTitleCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteIProudureTitle(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProudureTitleCard>> GetAllIProudureTitle()
        {
            throw new NotImplementedException();
        }

        public async Task<ProudureTitleCard> GetIProudureTitle(int id)
        {
            var response = from proc in _context.ProcedureTitles
                           where proc.Id == id
                           orderby proc.Id descending
                           select new ProudureTitleCard
                           {
                               CreationDate = proc.CreationDate,
                               Id= proc.Id,
                               name= proc.Name,
                           };
            var query = await response.FirstOrDefaultAsync();
            if (query != null)
            {
                //return await response.FirstOrDefaultAsync();

                //return await response.SingleOrDefaultAsync();
                return await response.LastOrDefaultAsync();
            }
            throw new Exception(ExceptionsConstant.TitleNotExisit);


        }

        public async Task UpdateIProudureTitle(ProudureTitleUpdate dto)
        {
            throw new NotImplementedException();
        }
    }
}
