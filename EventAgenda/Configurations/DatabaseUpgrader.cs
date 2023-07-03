using DbUp;

namespace EventAgenda.Configurations
{
    public class DatabaseUpgrader
    {
        private readonly string _connectionStrig;

        public DatabaseUpgrader(IConfiguration configuration)
        {
            _connectionStrig = configuration.GetConnectionString("DefaultConnection")!;
        }

        public void Upgrade()
        {
            EnsureDatabase.For.SqlDatabase(_connectionStrig);
            var upgrader = DeployChanges.To.SqlDatabase(_connectionStrig)
                .WithScriptsFromFileSystem("../SqlScripts/")
                .WithTransactionPerScript()
                .LogToConsole()
                .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
            }
        }
    }
}