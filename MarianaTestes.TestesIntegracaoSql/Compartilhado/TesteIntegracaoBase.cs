using FizzWare.NBuilder;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.InfraData.SqlServer.ModuloDisciplina;
using MarianaTestes.InfraData.SqlServer.ModuloMateria;
using MarianaTestes.InfraData.SqlServer.ModuloQuestao;
using MarianaTestes.InfraData.SqlServer.ModuloTeste;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace MarianaTestes.TestesIntegracaoSql.Compartilhado
{
    public abstract class TesteIntegracaoBase
    {
        protected RepositorioDisciplinaSql repositorioDisciplina;
        protected RepositorioMateriaSql repositorioMateria;
        protected RepositorioQuestaoSql repositorioQuestao;
        protected RepositorioTesteSql repositorioTeste;
        protected string connectionString;

        public TesteIntegracaoBase()
        {
            connectionString = ObterObterEnderecoBanco();

            LimparTabelas();

            repositorioDisciplina = new RepositorioDisciplinaSql(connectionString);
            repositorioMateria = new RepositorioMateriaSql(connectionString);
            repositorioQuestao = new RepositorioQuestaoSql(connectionString);
            repositorioTeste = new RepositorioTesteSql(connectionString);

            BuilderSetup.SetCreatePersistenceMethod<Disciplina>(repositorioDisciplina.Cadastrar);
            BuilderSetup.SetCreatePersistenceMethod<Materia>(repositorioMateria.Cadastrar);
            BuilderSetup.SetCreatePersistenceMethod<Questao>(repositorioQuestao.Cadastrar);
            BuilderSetup.SetCreatePersistenceMethod<Teste>(repositorioTeste.Cadastrar);

        }


        public static string ObterObterEnderecoBanco()
        {
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuracao.GetConnectionString("SqlServer_Testes")!;
        }


        protected Questao PersistirQuestao(Materia materia)
        {           
            var alternativas = Builder<Alternativa>
            .CreateListOfSize(4).Build().Cast<Alternativa>()
                .ToList();

            var questao = Builder<Questao>.CreateNew()
            .With(x => x.Materia = materia)
            .With(x => x.Alternativas = alternativas)
            .Persist();

            return questao;
        }

        protected Disciplina PersisitirDisciplina(string nome)
        {
            return Builder<Disciplina>.CreateNew().With(x => x.Nome = nome).Persist();
        }

        protected Materia PersistirMateria(Disciplina disciplina, string nome = "Teste")
        {          
            var calculo = Builder<Materia>.CreateNew()
                .With(x => x.Disciplina = disciplina)
                .With(x => x.Nome = nome)
                .Persist();

            return calculo;
        }

        protected void PersistirTeste()
        {
            var matematica = Builder<Disciplina>.CreateNew()
                .Persist();

            var calculo = Builder<Materia>.CreateNew()
                .With(x => x.Disciplina = matematica)
                .Persist();

            var alternativas = Builder<Alternativa>
                .CreateListOfSize(4).Build().Cast<Alternativa>().ToList();

            var listaQuestoes = Builder<Questao>
                .CreateListOfSize(15).Build().Cast<Questao>().ToList();

            listaQuestoes.ForEach(x =>
            {
                x.Alternativas = alternativas;
                x.Materia = calculo;
                repositorioQuestao.Cadastrar(x);
            });

            var teste = Builder<Teste>.CreateNew()
                .With(x => x.Disciplina = calculo.Disciplina)
                .With(x => x.Materia = calculo)
                .Do(x => x.ObterQuestoesSorteadas(listaQuestoes, 5))
                .Persist();
        }

        private void LimparTabelas()
        {
            var conexao = new SqlConnection(connectionString);

            var commando = conexao.CreateCommand();

            commando.CommandText = @"

                DELETE FROM [DBO].[TB_TESTE_TB_QUESTAO]
               
                DELETE FROM [DBO].[TB_TESTE]
                DBCC CHECKIDENT ('[TB_TESTE]', RESEED, 0);

                DELETE FROM [DBO].[TB_ALTERNATIVA]
                DBCC CHECKIDENT ('[TB_ALTERNATIVA]', RESEED, 0);

                DELETE FROM [DBO].[TB_QUESTAO]
                DBCC CHECKIDENT ('[TB_QUESTAO]', RESEED, 0);

                DELETE FROM [DBO].[TB_MATERIA]
                DBCC CHECKIDENT ('[TB_MATERIA]', RESEED, 0);

                DELETE FROM [DBO].[TB_DISCIPLINA]
                DBCC CHECKIDENT ('[TB_DISCIPLINA]', RESEED, 0);";

            conexao.Open();

            commando.ExecuteNonQuery();

            conexao.Close();
        }



    }
}
