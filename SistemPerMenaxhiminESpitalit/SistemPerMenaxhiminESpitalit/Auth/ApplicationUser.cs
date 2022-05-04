using Microsoft.AspNetCore.Identity;

namespace SistemPerMenaxhiminESpitalit.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
    }
}
