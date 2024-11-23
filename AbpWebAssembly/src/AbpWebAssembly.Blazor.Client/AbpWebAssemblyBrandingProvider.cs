using Microsoft.Extensions.Localization;
using AbpWebAssembly.Localization;
using Microsoft.Extensions.Localization;
using AbpWebAssembly.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpWebAssembly.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AbpWebAssemblyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpWebAssemblyResource> _localizer;

    public AbpWebAssemblyBrandingProvider(IStringLocalizer<AbpWebAssemblyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
