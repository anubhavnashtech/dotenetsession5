using System;

namespace interfaceextensiility
{

    public interface ILogger
    {
        void LogError(string message);

        void LogInfor(string message);
    }

    public class ConsoleLoge : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
        }

        public void LogInfor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
          using  var streamwtiter = new StreamWriter(_path , true);
            streamwtiter.Write("Error:" + message);

        }

        public void LogInfor(string message)
        {
           using var streamwtiter = new StreamWriter(_path , true);
            streamwtiter.Write("Info:" + message);
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {

          _logger.LogInfor("Migration stated at " + DateTime.Now);

            // Details of migrating the datbase
            
          _logger.LogInfor("Migration finished at " + DateTime.Now);

        }
    }




    public class Program
    {
        static void Main(string[] args)
        {
             var dbMigrator = new DbMigrator(new ConsoleLoge());

             dbMigrator.Migrate();

             var dbMigrator1 = new DbMigrator(new FileLogger("C:\\C# course\\Test\\log"));

            dbMigrator1.Migrate();

        }
    }
}
