using MarianaTestes.WinFormsApp.Compartilhado;
using Serilog;
using Serilog.Sinks.MSSqlServer;

namespace MarianaTestes.WinFormsApp
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ConfiguracaoSerilog.ConfigurarSerilog_Seq();

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm());

            Log.CloseAndFlush();
        }    
    }
}