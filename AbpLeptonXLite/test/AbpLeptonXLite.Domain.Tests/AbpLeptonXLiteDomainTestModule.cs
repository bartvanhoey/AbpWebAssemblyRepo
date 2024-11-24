using Volo.Abp.Modularity;

namespace AbpLeptonXLite;

[DependsOn(
    typeof(AbpLeptonXLiteDomainModule),
    typeof(AbpLeptonXLiteTestBaseModule)
)]
public class AbpLeptonXLiteDomainTestModule : AbpModule
{

}
