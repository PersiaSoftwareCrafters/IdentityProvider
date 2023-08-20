using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.Persistence.IdentityStore.Models;

namespace Shared.Persistence.IdentityStore.DbContexts
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
