using AbpWebAssembly.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpWebAssembly.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpWebAssemblyController : AbpControllerBase
{
    protected AbpWebAssemblyController()
    {
        LocalizationResource = typeof(AbpWebAssemblyResource);
    }
}
