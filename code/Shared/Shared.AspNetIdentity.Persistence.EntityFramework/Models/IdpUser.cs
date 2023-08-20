using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Shared.AspNetIdentity.Persistence.EntityFramework.Models
{
    public class IdpUser:IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Mobile { get; set; }
        public bool? MobileConfirmed { get; set; }

    }

   
}
