using Volo.Abp.Modularity;

namespace AbpLeptonXLite;

public abstract class AbpLeptonXLiteApplicationTestBase<TStartupModule> : AbpLeptonXLiteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
