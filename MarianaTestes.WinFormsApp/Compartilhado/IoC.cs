using MarianaTestes.Aplicacao.ModuloDisciplina;
using MarianaTestes.Aplicacao.ModuloMateria;
using MarianaTestes.Aplicacao.ModuloQuestao;
using MarianaTestes.Aplicacao.ModuloTeste;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.SqlServer.ModuloDisciplina;
using MarianaTestes.InfraData.SqlServer.ModuloMateria;
using MarianaTestes.InfraData.SqlServer.ModuloQuestao;
using MarianaTestes.InfraData.SqlServer.ModuloTeste;
using MarianaTestes.WinFormsApp.ModuloDisciplina;
using MarianaTestes.WinFormsApp.ModuloMateria;
using MarianaTestes.WinFormsApp.ModuloQuestao;
using MarianaTestes.WinFormsApp.ModuloTeste;
using Microsoft.Extensions.Configuration;

namespace MarianaTestes.WinFormsApp.Compartilhado
{
    public static class IoC
    {

        static IDictionary<string, ControladorBase> controladores = new Dictionary<string, ControladorBase>();
        static IoC()
        {
            var connectionString = ObterObterEnderecoBanco();

            IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaSql(connectionString);
            IRepositorioMateria repositorioMateria = new RepositorioMateriaSql(connectionString);
            IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoSql(connectionString);
            IRepositorioTeste repositorioTeste = new RepositorioTesteSql(connectionString);

            ServicoDisciplina servicoDisciplina = new ServicoDisciplina(repositorioDisciplina, new ValidadorDisciplina());
            ServicoMateria servicoMateria = new ServicoMateria(repositorioMateria, new ValidadorMateria());
            ServicoQuestao servicoQuestao = new ServicoQuestao(repositorioQuestao, new ValidadorQuestao());
            ServicoTeste servicoTeste = new ServicoTeste(repositorioTeste, new ValidadorTeste());

            ControladorDisciplina controladorDisciplina = new ControladorDisciplina(repositorioDisciplina, servicoDisciplina);
            ControladorMateria controladorMateria = new ControladorMateria(repositorioMateria, repositorioDisciplina,servicoMateria);
            ControladorQuestao controladorQuestao = new ControladorQuestao(repositorioQuestao, repositorioMateria,servicoQuestao);
            ControladorTeste controladorTeste = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao, servicoTeste);

            controladores.Add("Disciplina", controladorDisciplina);
            controladores.Add("Matéria", controladorMateria);
            controladores.Add("Questão", controladorQuestao);
            controladores.Add("Teste", controladorTeste);
        }

        public static ControladorBase ObterControlador(object sender)
        {
            ToolStripMenuItem control = (ToolStripMenuItem)sender;

            return controladores[control.Text];
        }

        private static string ObterObterEnderecoBanco()
        {
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuracao.GetConnectionString("SqlServer")!;
        }
    }
}
