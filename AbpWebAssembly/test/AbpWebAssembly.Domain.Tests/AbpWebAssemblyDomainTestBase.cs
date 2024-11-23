using Volo.Abp.Modularity;

namespace AbpWebAssembly;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpWebAssemblyDomainTestBase<TStartupModule> : AbpWebAssemblyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
