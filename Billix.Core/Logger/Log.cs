using Serilog;

namespace Billix.Core
{
    public static class Log
    {
        static Log()
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(
                    outputTemplate: "[{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .WriteTo.File(
                    "Logs/Billix-Logs-.txt",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 31
                )
                .CreateLogger();
        }

        public static void Verbose(string message)
        {
            Serilog.Log.Verbose(message);
        }

        public static void Verbose(string message, Exception ex)
        {
            Serilog.Log.Verbose(ex, message);
        }

        public static void Debug(string message)
        {
            Serilog.Log.Debug(message);
        }

        public static void Debug(string message, Exception ex)
        {
            Serilog.Log.Debug(ex, message);
        }

        public static void Info(string message)
        {
            Serilog.Log.Information(message);
        }

        public static void Info(string message, Exception ex)
        {
            Serilog.Log.Information(ex, message);
        }

        public static void Error(string message)
        {
            Serilog.Log.Error(message);
        }

        public static void Error(string message, Exception ex)
        {
            Serilog.Log.Error(ex, message);
        }

        public static void Fatal(string message)
        {
            Serilog.Log.Fatal(message);
        }

        public static void Fatal(string message, Exception ex)
        {
            Serilog.Log.Fatal(ex, message);
        }

    }
}
