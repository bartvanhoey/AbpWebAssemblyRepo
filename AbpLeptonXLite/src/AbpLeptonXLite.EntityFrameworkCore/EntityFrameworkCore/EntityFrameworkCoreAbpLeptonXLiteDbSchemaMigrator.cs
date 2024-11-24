using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpLeptonXLite.Data;
using Volo.Abp.DependencyInjection;

namespace AbpLeptonXLite.EntityFrameworkCore;

public class EntityFrameworkCoreAbpLeptonXLiteDbSchemaMigrator
    : IAbpLeptonXLiteDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpLeptonXLiteDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpLeptonXLiteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpLeptonXLiteDbContext>()
            .Database
            .MigrateAsync();
    }
}
