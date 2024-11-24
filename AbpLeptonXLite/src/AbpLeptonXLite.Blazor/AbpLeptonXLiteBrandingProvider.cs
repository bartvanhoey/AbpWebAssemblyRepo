using Microsoft.Extensions.Localization;
using AbpLeptonXLite.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpLeptonXLite.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpLeptonXLiteBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpLeptonXLiteResource> _localizer;

    public AbpLeptonXLiteBrandingProvider(IStringLocalizer<AbpLeptonXLiteResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
