﻿namespace SecurityTokenService.Persistence.ConfigurationStore.Options
{
    public class ConfiguratonStoreOptions
    {
        public string? ConnectionString { get; set; }
        public string? MigrationsAssembly { get; set; }
        public string? MigrationsHistoryTable { get; set; }
        public string? Schema { get; set; }
    }
}
