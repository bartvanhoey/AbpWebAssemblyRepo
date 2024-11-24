using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpLeptonXLite.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpLeptonXLiteDbContextFactory : IDesignTimeDbContextFactory<AbpLeptonXLiteDbContext>
{
    public AbpLeptonXLiteDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpLeptonXLiteEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpLeptonXLiteDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpLeptonXLiteDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpLeptonXLite.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
