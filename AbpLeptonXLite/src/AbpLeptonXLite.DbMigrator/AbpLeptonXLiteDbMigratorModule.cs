using AbpLeptonXLite.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpLeptonXLite.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpLeptonXLiteEntityFrameworkCoreModule),
    typeof(AbpLeptonXLiteApplicationContractsModule)
)]
public class AbpLeptonXLiteDbMigratorModule : AbpModule
{
}
