using AbpLeptonXLite.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpLeptonXLite.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpLeptonXLiteController : AbpControllerBase
{
    protected AbpLeptonXLiteController()
    {
        LocalizationResource = typeof(AbpLeptonXLiteResource);
    }
}
