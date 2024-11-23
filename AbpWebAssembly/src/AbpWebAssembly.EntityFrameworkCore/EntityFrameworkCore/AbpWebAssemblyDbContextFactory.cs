using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpWebAssembly.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpWebAssemblyDbContextFactory : IDesignTimeDbContextFactory<AbpWebAssemblyDbContext>
{
    public AbpWebAssemblyDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpWebAssemblyEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpWebAssemblyDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpWebAssemblyDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpWebAssembly.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
