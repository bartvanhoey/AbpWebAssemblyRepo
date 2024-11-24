using System.Threading.Tasks;

namespace AbpLeptonXLite.Data;

public interface IAbpLeptonXLiteDbSchemaMigrator
{
    Task MigrateAsync();
}
