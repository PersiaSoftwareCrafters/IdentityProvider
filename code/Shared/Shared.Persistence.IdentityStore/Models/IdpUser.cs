using Microsoft.AspNetCore.Identity;

namespace Shared.Persistence.IdentityStore.Models
{
    public class IdpUser:IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Mobile { get; set; }
        public bool? MobileConfirmed { get; set; }

    }

   
}
