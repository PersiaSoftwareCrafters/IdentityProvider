using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.AspNetIdentity.Persistence.EntityFramework.Options
{
    public class IdentityStoreOptions
    {
        public string? ConnectionString { get; set; }
        public string? MigrationsAssembly { get; set; }
        public string? MigrationsHistoryTable { get; set; }
        public string? Schema { get; set; }
    }
}
