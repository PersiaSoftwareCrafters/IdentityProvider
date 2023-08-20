using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shared.AspNetIdentity.Persistence.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Shared.AspNetIdentity.Persistence.EntityFramework.DbContexts
{
    public class IdpDbContext: IdentityDbContext<IdpUser>
    {
        public IdpDbContext(DbContextOptions<IdpDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
