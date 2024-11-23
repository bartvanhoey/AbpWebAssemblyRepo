using Volo.Abp.Modularity;

namespace AbpWebAssembly;

public abstract class AbpWebAssemblyApplicationTestBase<TStartupModule> : AbpWebAssemblyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
