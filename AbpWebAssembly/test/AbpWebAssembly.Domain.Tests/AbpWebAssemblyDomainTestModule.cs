using Volo.Abp.Modularity;

namespace AbpWebAssembly;

[DependsOn(
    typeof(AbpWebAssemblyDomainModule),
    typeof(AbpWebAssemblyTestBaseModule)
)]
public class AbpWebAssemblyDomainTestModule : AbpModule
{

}
