using AbpLeptonXLite.Localization;
using Volo.Abp.Application.Services;

namespace AbpLeptonXLite;

/* Inherit your application services from this class.
 */
public abstract class AbpLeptonXLiteAppService : ApplicationService
{
    protected AbpLeptonXLiteAppService()
    {
        LocalizationResource = typeof(AbpLeptonXLiteResource);
    }
}
