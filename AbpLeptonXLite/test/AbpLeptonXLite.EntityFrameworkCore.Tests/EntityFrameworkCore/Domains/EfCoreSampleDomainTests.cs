using AbpLeptonXLite.Samples;
using Xunit;

namespace AbpLeptonXLite.EntityFrameworkCore.Domains;

[Collection(AbpLeptonXLiteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpLeptonXLiteEntityFrameworkCoreTestModule>
{

}
