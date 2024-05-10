using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.DTOs.Appointment;

namespace ClinicManagmentAPI.Implementations
{
    public class ApointmentService : IApointmentService
    {
        public async Task AddNewAppointment(CreateAppointmentDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetAllAppointmentDTO>> AllAppointment(DateTime? date)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateExistedAppointment(UpdateAppoitmentDTO dto, int id)
        {
            throw new NotImplementedException();
        }
    }
}
