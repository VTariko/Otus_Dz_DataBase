using System.Reflection;
using Npgsql;

namespace otus.dz.DataAccess.PostgreSQL;

public class Migrator
{
    public static void MigrateDatabase()
    {
        var host = Environment.GetEnvironmentVariable("DATABASE_HOST");
        var port = Environment.GetEnvironmentVariable("DATABASE_PORT");
        var database = Environment.GetEnvironmentVariable("DATABASE_NAME");
        var username = Environment.GetEnvironmentVariable("DATABASE_LOGIN");
        var password = Environment.GetEnvironmentVariable("DATABASE_PASSWORD");
        
        var connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";

        var dbConnection = new NpgsqlConnection(connectionString);

        var fullMigrationPath = GetFullMigrationPath();
        var evolve = new Evolve.Evolve(dbConnection)
        {
            Locations = new[] { fullMigrationPath },
            IsEraseDisabled = true
        };
        
        evolve.Migrate();

        string GetFullMigrationPath()
        {
            var migrationScriptsLocation = Environment.GetEnvironmentVariable("MIGRATION_SCRIPTS_PATH");
            var assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Join(assemblyDirectory, migrationScriptsLocation);
        }
    }
}