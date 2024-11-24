using Volo.Abp.Modularity;

namespace AbpLeptonXLite;

[DependsOn(
    typeof(AbpLeptonXLiteApplicationModule),
    typeof(AbpLeptonXLiteDomainTestModule)
)]
public class AbpLeptonXLiteApplicationTestModule : AbpModule
{

}
