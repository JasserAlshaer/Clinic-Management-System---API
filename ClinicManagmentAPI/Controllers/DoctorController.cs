using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ClinicManagementAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IMedicalReportService _medicalReportService;
        private readonly IMedicalProcedureService _medicalProcedureService;
        public DoctorController(IMedicalProcedureService medicalProcedureService, IMedicalReportService medicalReportService)
        {
            
            _medicalReportService = medicalReportService;
            _medicalProcedureService = medicalProcedureService;
        }
        /// <summary>
        /// Retrieves a Medical Report In My Db For Specifc Doctor
        /// </summary>
        /// <response code="200">Returns the available reports</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{doctorId}")]
        public async Task<IActionResult> GetMyMedicalReports([FromRoute]int doctorId)
        {
            try
            {
                Log.Information("GetMyMedicalReports Was Called For Doctor");
                Log.Information("GetMyMedicalReports Was Return For Doctor");
                return StatusCode(200, await _medicalReportService.GetAllMedicalReports(doctorId));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves a Procedure For Medical Report In My Db
        /// </summary>
        /// <response code="200">Returns the available  Procedure For Medical Report</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetProcedureForMedicalReports([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetProcedureForMedicalReports Was Called");
                Log.Information("GetProcedureForMedicalReports Was Return");
                return StatusCode(200, await _medicalProcedureService.GetAllMedicalProcedure(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
    }
}
