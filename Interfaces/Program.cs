using System;

namespace Interfaces
{

    // Interfaces allow the developer to create loosely coupled applications, by adding abstraction between layers.
    // This means one layer can change without having an effect on the other layer.

    // We will be upgrading this class
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine("Started the migration.");

            // .. Do some work

            Console.WriteLine("Completed the migration.");
        }
    }

    // Create a new logger interface
    public interface ILogger
    {
        void LogInfo(string info);
        void LogError(string error);
    }

    // In this code below, the new migrator class knows nothing about the logger.
    // Instead it is simply communicating with an interface for all its logging needs.
    public class NewDbMigrator
    {
        private ILogger _logger { get; }

        public NewDbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started");

            Console.WriteLine("Do some work!");

            _logger.LogInfo("Migration finished");
        }        
    }

    // This use of interfacing means we could change from logger to a different type of logging and
    // we would not have any effect on the Migration class, it would still behave as normal.

    public class logger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine(error);
        }

        public void LogInfo(string info)
        {
            Console.WriteLine(info);
        }
    }

    public class FileLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine("File logging Error");
        }

        public void LogInfo(string info)
        {
            Console.WriteLine("File logging Info");
        }
    }

    // In the example below we have extended the logging by adding a new file logger,
    // We have then been able to extend this logging class without making any impact on the NewDbMigration class.
    class MainClass
    {
        public static void Main()
        {
            var logger = new logger();
            //var migrator = new NewDbMigrator(logger);
            var migrator = new NewDbMigrator(new FileLogger());
            migrator.Migrate();
        }
    }

    // This is known as the 'Open/Closed principal within engineering, as software should be open for modification, but closed for change.'
}
