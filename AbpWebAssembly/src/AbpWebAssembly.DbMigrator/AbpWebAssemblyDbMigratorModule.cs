using AbpWebAssembly.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpWebAssembly.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpWebAssemblyEntityFrameworkCoreModule),
    typeof(AbpWebAssemblyApplicationContractsModule)
)]
public class AbpWebAssemblyDbMigratorModule : AbpModule
{
}
