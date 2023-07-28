using MarianaTestes.Aplicacao.ModuloDisciplina;
using MarianaTestes.Aplicacao.ModuloMateria;
using MarianaTestes.Aplicacao.ModuloQuestao;
using MarianaTestes.Aplicacao.ModuloTeste;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.Orm.Compartilhado;
using MarianaTestes.InfraData.Orm.ModuloDisciplina;
using MarianaTestes.InfraData.Orm.ModuloMateria;
using MarianaTestes.InfraData.Orm.ModuloQuestao;
using MarianaTestes.InfraData.Orm.ModuloTeste;
using MarianaTestes.WinFormsApp.ModuloDisciplina;
using MarianaTestes.WinFormsApp.ModuloMateria;
using MarianaTestes.WinFormsApp.ModuloQuestao;
using MarianaTestes.WinFormsApp.ModuloTeste;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MarianaTestes.WinFormsApp.Compartilhado
{
    public static class IoC
    {

        static IDictionary<string, ControladorBase> controladores = new Dictionary<string, ControladorBase>();
        static IoC()
        {
            var connectionString = ObterObterEnderecoBanco();

            var optionBuilder = new DbContextOptionsBuilder<MarianaTestesDbContext>();

            optionBuilder.UseSqlServer(connectionString);

            DbContext context = new MarianaTestesDbContext(optionBuilder.Options);

            MarianaTestesMigradorBandoDados.AtualizarBancoDados(context);

            IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaOrm(context);
            IRepositorioMateria repositorioMateria = new RepositorioMateriaOrm(context);
            IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoOrm(context);
            IRepositorioTeste repositorioTeste = new RepositorioTesteOrm(context);

            var servicoDisciplina = new ServicoDisciplina(repositorioDisciplina, new ValidadorDisciplina());
            var servicoMateria = new ServicoMateria(repositorioMateria, new ValidadorMateria());
            var servicoQuestao = new ServicoQuestao(repositorioQuestao, new ValidadorQuestao());
            var servicoTeste = new ServicoTeste(repositorioTeste, new ValidadorTeste(), repositorioQuestao);

            var controladorDisciplina = new ControladorDisciplina(repositorioDisciplina, servicoDisciplina);
            var controladorMateria = new ControladorMateria(repositorioMateria, repositorioDisciplina, servicoMateria);
            var controladorQuestao = new ControladorQuestao(repositorioQuestao, repositorioMateria, servicoQuestao);
            var controladorTeste = new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao, servicoTeste);

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
