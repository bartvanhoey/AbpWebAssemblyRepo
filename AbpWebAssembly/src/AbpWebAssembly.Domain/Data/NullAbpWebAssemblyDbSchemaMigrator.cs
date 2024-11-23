using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpWebAssembly.Data;

/* This is used if database provider does't define
 * IAbpWebAssemblyDbSchemaMigrator implementation.
 */
public class NullAbpWebAssemblyDbSchemaMigrator : IAbpWebAssemblyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
