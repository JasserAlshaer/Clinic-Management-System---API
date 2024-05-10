using ClinicManagementAPI.Interface;
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
        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                Log.Information("GetUsers Was Called");
                Log.Information("GetUsers Was Return");
                return Ok(await _userService.GetAllUsers());
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500,$"An Error Was Occurred {ex.Message}");
            }
        }
    }
}
