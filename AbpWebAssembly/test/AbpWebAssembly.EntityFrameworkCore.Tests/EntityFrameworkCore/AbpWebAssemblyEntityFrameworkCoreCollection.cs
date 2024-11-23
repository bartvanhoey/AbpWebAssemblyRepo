using Xunit;

namespace AbpWebAssembly.EntityFrameworkCore;

[CollectionDefinition(AbpWebAssemblyTestConsts.CollectionDefinitionName)]
public class AbpWebAssemblyEntityFrameworkCoreCollection : ICollectionFixture<AbpWebAssemblyEntityFrameworkCoreFixture>
{

}
