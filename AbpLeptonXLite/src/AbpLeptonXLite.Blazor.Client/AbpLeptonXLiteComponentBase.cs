using AbpLeptonXLite.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpLeptonXLite.Blazor.Client;

public abstract class AbpLeptonXLiteComponentBase : AbpComponentBase
{
    protected AbpLeptonXLiteComponentBase()
    {
        LocalizationResource = typeof(AbpLeptonXLiteResource);
    }
}
