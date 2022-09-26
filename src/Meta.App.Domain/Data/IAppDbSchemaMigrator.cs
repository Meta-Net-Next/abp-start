using System.Threading.Tasks;

namespace Meta.App.Data;

public interface IAppDbSchemaMigrator
{
    Task MigrateAsync();
}
