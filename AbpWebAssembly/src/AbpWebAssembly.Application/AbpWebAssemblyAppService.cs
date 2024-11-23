using AbpWebAssembly.Localization;
using Volo.Abp.Application.Services;

namespace AbpWebAssembly;

/* Inherit your application services from this class.
 */
public abstract class AbpWebAssemblyAppService : ApplicationService
{
    protected AbpWebAssemblyAppService()
    {
        LocalizationResource = typeof(AbpWebAssemblyResource);
    }
}
