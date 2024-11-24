using AbpLeptonXLite.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpLeptonXLite.Blazor;

public abstract class AbpLeptonXLiteComponentBase : AbpComponentBase
{
    protected AbpLeptonXLiteComponentBase()
    {
        LocalizationResource = typeof(AbpLeptonXLiteResource);
    }
}
