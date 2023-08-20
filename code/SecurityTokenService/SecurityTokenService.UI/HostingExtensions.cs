using Microsoft.EntityFrameworkCore;
using SecurityTokenService.Persistence.ConfigurationStore.Options;
using SecurityTokenService.Persistence.OperationalStore.Options;
using Serilog;

namespace SecurityTokenService.UI;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var configurationStoreOptions = builder.Configuration.GetSection("ConfigurationStore").Get<ConfiguratonStoreOptions>();

        var operationalStoreOptions = builder.Configuration.GetSection("OperationalStore").Get<OperationalStoreOptions>();

        builder.Services.AddRazorPages();

        builder.Services.AddIdentityServer()
            .AddConfigurationStore(options =>
            {
                options.ConfigureDbContext = builder =>
                    builder.UseSqlServer(configurationStoreOptions.ConnectionString,
                        sql => sql.MigrationsAssembly(configurationStoreOptions.MigrationsAssembly)
                            .MigrationsHistoryTable(configurationStoreOptions.MigrationsHistoryTable, configurationStoreOptions.Schema));
            })
            .AddOperationalStore(options =>
            {
                options.ConfigureDbContext = builder =>
                    builder.UseSqlServer(operationalStoreOptions.ConnectionString,
                        sql => sql.MigrationsAssembly(operationalStoreOptions.MigrationsAssembly)
                            .MigrationsHistoryTable(operationalStoreOptions.MigrationsHistoryTable,
                                operationalStoreOptions.Schema));

                options.EnableTokenCleanup = true;
                options.TokenCleanupInterval = 3600;
            })
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryClients(Config.Clients);

        builder.Services.AddAuthentication();

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseSerilogRequestLogging();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();
        app.UseIdentityServer();
        app.UseAuthorization();

        app.MapRazorPages()
            .RequireAuthorization();

        return app;
    }
}