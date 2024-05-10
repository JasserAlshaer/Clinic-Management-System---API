
using ClinicManagmentAPI.DTOs.Appointment;

namespace ClinicManagementAPI.Interface
{
    public interface IApointmentService
    {
        Task <AppontimentDTO>GetAppoitnmentDetails(int Id);
        Task AddNewAppointment(CreateAppointmentDTO dto);

        Task<List<GetAllAppointmentDTO>> AllAppointment(DateTime? date); // DateTime? date To allow filtering on dates  

        Task UpdateExistedAppointment(UpdateAppoitmentDTO dto, int id);

        Task DeleteAppointment(int id);
    }
}
