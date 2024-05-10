using ClinicManagmentAPI.Context;

namespace ClinicManagmentAPI.Implementations.baseImplementation
{
    public class BaseAppService
    {
        protected readonly ClinicManagementDbContext _context;

        public BaseAppService(ClinicManagementDbContext context)
        {
            _context = context;
        }
    }
}
