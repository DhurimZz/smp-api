using Microsoft.AspNetCore.Mvc;

namespace SistemPerMenaxhiminESpitalit.Controllers
{
    public class RegisterRequest
    {
        private string name { get; set; }
    }

    [ApiController]
    [Route("doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> _logger;

        public DoctorsController(ILogger<DoctorsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("register")]
        public string Register(string name, string email)
        {
            return name;
        }
    }
}