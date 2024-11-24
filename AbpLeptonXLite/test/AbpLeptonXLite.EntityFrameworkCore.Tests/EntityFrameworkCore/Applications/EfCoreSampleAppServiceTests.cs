using AbpLeptonXLite.Samples;
using Xunit;

namespace AbpLeptonXLite.EntityFrameworkCore.Applications;

[Collection(AbpLeptonXLiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpLeptonXLiteEntityFrameworkCoreTestModule>
{

}
