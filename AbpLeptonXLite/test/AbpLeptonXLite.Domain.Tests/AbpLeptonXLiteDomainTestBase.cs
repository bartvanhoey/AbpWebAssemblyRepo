using Volo.Abp.Modularity;

namespace AbpLeptonXLite;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpLeptonXLiteDomainTestBase<TStartupModule> : AbpLeptonXLiteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
