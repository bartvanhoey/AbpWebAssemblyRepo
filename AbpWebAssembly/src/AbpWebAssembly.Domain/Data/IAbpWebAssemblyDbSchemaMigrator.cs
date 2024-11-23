using System.Threading.Tasks;

namespace AbpWebAssembly.Data;

public interface IAbpWebAssemblyDbSchemaMigrator
{
    Task MigrateAsync();
}
