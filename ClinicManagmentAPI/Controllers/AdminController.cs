using ClinicManagementAPI.Interface;
using ClinicManagmentAPI.Helper.Exceptions;
using ClinicManagmentAPI.Implementations;
using ClinicManagmentAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ClinicManagementAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMedicalReportService _medicalReportService;
        private readonly IMedicalProcedureService _medicalProcedureService;
        private readonly IApointmentService _apointmentService;
        private readonly IInvoiceService _invoiceService;
        private readonly IMedicienService _medicienService;
        private readonly IProudureTitleService _proudureTitleService;
        private readonly IMedicalReportAttachmentService _attachmentService;
        public AdminController(IUserService userService,
            IMedicalProcedureService medicalProcedureService,
            IApointmentService apointmentService,
            IInvoiceService invoiceService,
            IProudureTitleService proudureTitleService,
            IMedicienService medicienService,
            IMedicalReportAttachmentService attachmentService,
            IMedicalReportService medicalReportService)
        {
            _userService = userService;
            _medicalProcedureService=medicalProcedureService;
            _medicalReportService = medicalReportService;
            _apointmentService = apointmentService;
            _invoiceService = invoiceService;
            _medicienService= medicienService;
            _proudureTitleService = proudureTitleService;
            _attachmentService = attachmentService;
        }
        /// <summary>
        /// Retrieves a Users In My Db
        /// </summary>
        /// <response code="200">Returns the available users</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                Log.Information("GetUsers Was Called");
                Log.Information("GetUsers Was Return");
                return StatusCode(200,await _userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500,$"An Error Was Occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves a Medical Report In My Db
        /// </summary>
        /// <response code="200">Returns the available reports</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetMedicalReports()
        {
            try
            {
                Log.Information("GetMedicalReports Was Called");
                Log.Information("GetMedicalReports Was Return");
                return StatusCode(200, await _medicalReportService.GetAllMedicalReports());
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
        public async Task<IActionResult> GetProcedureForMedicalReports([FromRoute]int Id)
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

        /// <summary>
        /// Retrieves a GetAppointmentDetails In My Db
        /// </summary>
        /// <response code="200">Returns the GetAppointmentDetails </response>
        /// <response code="404">Returns If There is no any Matched Object</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetAppointmentDetails([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetAppointmentDetails Was Called");
                Log.Information("GetAppointmentDetails Was Return");
                return StatusCode(200, await _apointmentService.GetAppoitnmentDetails(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.Message.Equals(ExceptionsConstant.AppointmentNotExisit))
                    return StatusCode(404, $"Object Dose not Exist : {ex.Message}");
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves an Invoice In My Db
        /// </summary>
        /// <response code="200">Returns the Invoice </response>
        /// <response code="404">Returns If There is no any Matched Object</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetInvoiceObject([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetInvoiceObject Was Called");
                Log.Information("GetInvoiceObject Was Return");
                return StatusCode(200, await _invoiceService.GetInvoice(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.Message.Equals(ExceptionsConstant.InvoiceNotExisit))
                    return StatusCode(404, $"Object Dose not Exist : {ex.Message}");
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves an GetProudureTitleObject In My Db
        /// </summary>
        /// <response code="200">Returns the ProudureTitle </response>
        /// <response code="404">Returns If There is no any Matched Object</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetProudureTitleObject([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetProudureTitleObject Was Called");
                Log.Information("GetProudureTitleObject Was Return");
                return StatusCode(200, await _proudureTitleService.GetIProudureTitle(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.Message.Equals(ExceptionsConstant.TitleNotExisit))
                    return StatusCode(404, $"Object Dose not Exist : {ex.Message}");
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves an Medicine In My Db
        /// </summary>
        /// <response code="200">Returns the Medicine </response>
        /// <response code="404">Returns If There is no any Matched Object</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetMedicineObject([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetMedicineObject Was Called");
                Log.Information("GetMedicineObject Was Return");
                return StatusCode(200, await _medicienService.GetMedicienById(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.Message.Equals(ExceptionsConstant.MediciennNotExisit))
                    return StatusCode(404, $"Object Dose not Exist : {ex.Message}");
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
        /// <summary>
        /// Retrieves an Attachment In My Db
        /// </summary>
        /// <response code="200">Returns the Attachment </response>
        /// <response code="404">Returns If There is no any Matched Object</response>
        /// <response code="500">If there is an error</response>  
        [HttpGet]
        [Route("[action]/{Id}")]
        public async Task<IActionResult> GetAttachmentObjectById([FromRoute] int Id)
        {
            try
            {
                Log.Information("GetAttachmentObjectById Was Called");
                Log.Information("GetAttachmentObjectById Was Return");
                return StatusCode(200, await _attachmentService.GetReportAttachementById(Id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.Message.Equals(ExceptionsConstant.AttachmentNotExisit))
                    return StatusCode(404, $"Object Dose not Exist : {ex.Message}");
                return StatusCode(500, $"An Error Was Occurred {ex.Message}");
            }
        }
    }
}
