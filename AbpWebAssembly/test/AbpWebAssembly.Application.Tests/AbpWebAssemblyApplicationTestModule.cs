using Volo.Abp.Modularity;

namespace AbpWebAssembly;

[DependsOn(
    typeof(AbpWebAssemblyApplicationModule),
    typeof(AbpWebAssemblyDomainTestModule)
)]
public class AbpWebAssemblyApplicationTestModule : AbpModule
{

}
