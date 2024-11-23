using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpWebAssembly.Data;
using Volo.Abp.DependencyInjection;

namespace AbpWebAssembly.EntityFrameworkCore;

public class EntityFrameworkCoreAbpWebAssemblyDbSchemaMigrator
    : IAbpWebAssemblyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpWebAssemblyDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpWebAssemblyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpWebAssemblyDbContext>()
            .Database
            .MigrateAsync();
    }
}
