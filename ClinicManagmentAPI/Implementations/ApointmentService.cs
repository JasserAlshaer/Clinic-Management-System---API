using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Context;
using ClinicManagmentAPI.DTOs.Appointment;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations.baseImplementation;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagmentAPI.Implementations
{
    public class ApointmentService : BaseAppService, IApointmentService
    {
        public ApointmentService(ClinicManagementDbContext context) : base(context)
        {
        }

        public async Task<AppontimentDTO>GetAppoitnmentDetails(int Id)
        {
            //First Or Default (Nullable)
            var result = await _context.Appointments.FirstOrDefaultAsync(x => x.Id == Id);
            if (result != null)
            {
                var person = await _context.Users.FirstOrDefaultAsync(x => x.Id == result.UserId);
                var doctor = await _context.Users.FirstOrDefaultAsync(x => x.Id == result.DoctorId);
                AppontimentDTO response = new AppontimentDTO()
                {
                    Status = result.Status.ToString(),
                    Date = result.Date,
                    Description = result.Description,
                    PatientName = person ==null?"No Patient" :person.Name,
                    DoctorName = doctor == null ? "No Doctor" : doctor.Name,
                };
                return response;
            }
            throw new Exception(ExceptionsConstant.AppointmentNotExisit);
        }
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
