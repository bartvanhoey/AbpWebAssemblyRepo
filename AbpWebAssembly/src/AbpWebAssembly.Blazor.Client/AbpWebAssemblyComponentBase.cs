using AbpWebAssembly.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpWebAssembly.Blazor.Client;

public abstract class AbpWebAssemblyComponentBase : AbpComponentBase
{
    protected AbpWebAssemblyComponentBase()
    {
        LocalizationResource = typeof(AbpWebAssemblyResource);
    }
}
