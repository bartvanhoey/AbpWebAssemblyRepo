using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using AbpLeptonXLite.Localization;

namespace AbpLeptonXLite.Blazor.Client;

public class AbpLeptonXLiteBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpLeptonXLiteResource> _localizer;

    public AbpLeptonXLiteBrandingProvider(IStringLocalizer<AbpLeptonXLiteResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
