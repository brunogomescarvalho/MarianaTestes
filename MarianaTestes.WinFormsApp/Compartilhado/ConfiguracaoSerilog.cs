using Serilog.Sinks.MSSqlServer;
using Serilog;

namespace MarianaTestes.WinFormsApp.Compartilhado
{
    public static class ConfiguracaoSerilog
    {
        private const string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestesMariana_LogDB;Integrated Security=True;Pooling=False";
        private const string _schemaName = "dbo";
        private const string _tableName = "LogEvents";

        public static void ConfigurarSerilog_Sql()
        {

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.MSSqlServer(
            connectionString: _connectionString,
            sinkOptions: new MSSqlServerSinkOptions
            {
                TableName = _tableName,
                SchemaName = _schemaName,
                AutoCreateSqlTable = true
            })
            .CreateLogger();

        }

        public static void ConfigurarSerilog_Arquivo()
        {
            Log.Logger = new LoggerConfiguration()
             .MinimumLevel.Debug()
             .WriteTo.File("logs/gerador-testes.txt", rollingInterval: RollingInterval.Minute, retainedFileCountLimit: 5)
               .CreateLogger();
        }

        public static void ConfigurarSerilog_Seq()
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Seq("http://localhost:5341")    
              .CreateLogger();
        }
    }
}
