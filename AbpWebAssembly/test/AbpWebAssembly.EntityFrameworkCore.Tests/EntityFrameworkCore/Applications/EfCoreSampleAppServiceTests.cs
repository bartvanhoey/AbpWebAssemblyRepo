using AbpWebAssembly.Samples;
using Xunit;

namespace AbpWebAssembly.EntityFrameworkCore.Applications;

[Collection(AbpWebAssemblyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpWebAssemblyEntityFrameworkCoreTestModule>
{

}
