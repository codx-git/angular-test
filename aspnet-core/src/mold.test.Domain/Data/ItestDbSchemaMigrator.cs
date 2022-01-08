using System.Threading.Tasks;

namespace mold.test.Data
{
    public interface ItestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
