using otus.dz.DataAccess.PostgreSQL;

try
{
    Console.WriteLine("Migrator started");
    RunMigration();
    Console.WriteLine("Migrator finished");
}
catch (Exception exception)
{
    Console.WriteLine($"Произошло необработанное исключение при работе мигратора {exception}", exception);
}


static void RunMigration()
{
    Console.WriteLine("DbMigration running");
    Migrator.MigrateDatabase();
    Console.WriteLine("DbMigration completed");
}