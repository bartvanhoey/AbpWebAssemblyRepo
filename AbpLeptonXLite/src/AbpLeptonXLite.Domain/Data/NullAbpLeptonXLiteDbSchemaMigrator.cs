using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpLeptonXLite.Data;

/* This is used if database provider does't define
 * IAbpLeptonXLiteDbSchemaMigrator implementation.
 */
public class NullAbpLeptonXLiteDbSchemaMigrator : IAbpLeptonXLiteDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
