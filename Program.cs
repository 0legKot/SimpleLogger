using System;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = LoggerService.GetLogger();
            logger.Info("Simple logger: Info message");
            Console.WriteLine("-------------------------");
            logger.Warn("Simple logger: Warn message");
            Console.WriteLine("-------------------------");
            logger.Error("Simple logger: Error message");
            Console.WriteLine("-------------------------");
            logger.Debug("Simple logger: Debug message");
            Console.WriteLine("-------------------------");
            logger.Fatal("Simple logger: Fatal message");

            Console.WriteLine("************************");

            var batchLogger = LoggerService.GetBatchLogger();
            batchLogger.Info("Batch logger: Info message");
            Console.WriteLine("-------------------------");
            batchLogger.Warn("Batch logger: Warn message");
            Console.WriteLine("-------------------------");
            batchLogger.Error("Batch logger: Error message");
            Console.WriteLine("-------------------------");
            batchLogger.Debug("Batch logger: Debug message");
            Console.WriteLine("-------------------------");
            batchLogger.Fatal("Batch logger: Fatal message");
            Console.WriteLine("-------------------------");
            batchLogger.Flush();

            Console.WriteLine("************************");
        }
    }
}
