using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemPerMenaxhiminESpitalit.Auth;

namespace SistemPerMenaxhiminESpitalit.Controllers
{
    public class RegisterRequest
    {
        private string name { get; set; }
    }

    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;


        public DoctorsController(ILogger<DoctorsController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet("get-doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            string roleName = "doctor";
            return Ok(await _userManager.GetUsersInRoleAsync(roleName));
        }
        [HttpDelete("delete-doctor/{id}")]
        public async Task<IActionResult> DeleteDoctors(string id)
        {
            try{
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                string roleName = "doctor";
                return Ok(await _userManager.DeleteAsync(user));
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}