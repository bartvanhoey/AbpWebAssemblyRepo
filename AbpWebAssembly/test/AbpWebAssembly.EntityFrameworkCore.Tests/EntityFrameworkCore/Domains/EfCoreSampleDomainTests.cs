using AbpWebAssembly.Samples;
using Xunit;

namespace AbpWebAssembly.EntityFrameworkCore.Domains;

[Collection(AbpWebAssemblyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpWebAssemblyEntityFrameworkCoreTestModule>
{

}
