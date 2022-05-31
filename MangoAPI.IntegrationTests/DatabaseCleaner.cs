using System.Threading.Tasks;
using Respawn;
using Respawn.Graph;

namespace MangoAPI.IntegrationTests
{
    public static class DatabaseCleaner
    {
        public static async Task Clean(string connectionString, string schema)
        {
            var checkpoint = new Checkpoint
            {
                TablesToIgnore = new Table[]
                {
                    "__EFMigrationsHistory"
                },
                SchemasToInclude = new[] {schema},
                WithReseed = true
            };

            await checkpoint.Reset(connectionString);
        }
    }
}