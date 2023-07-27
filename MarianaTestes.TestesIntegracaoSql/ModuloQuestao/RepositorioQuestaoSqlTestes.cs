using MarianaTestes.TestesIntegracaoSql.Compartilhado;
using FluentAssertions;

namespace MarianaTestes.TestesIntegracaoSql.ModuloQuestao
{
    [TestClass]

    public class RepositorioQuestaoSqlTestes : TesteIntegracaoBase
    {

        [TestMethod]
        public void Deve_cadastrar_questao()
        {
            //arrange
            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");

            var questao = PersistirQuestao(calculo);

            var questao2 = questao;

            //action
            repositorioQuestao.Cadastrar(questao2);

            //assert
            repositorioQuestao.BuscarTodos().Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_buscar_todas_as_questoes_com_alternativas()
        {
            //arrange
            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");

            var questao_1 = PersistirQuestao(calculo);
            var questao_2 = PersistirQuestao(calculo);

            //action
            var lista = repositorioQuestao.BuscarTodos();

            //assert
            lista.Should().ContainInOrder(questao_1, questao_2);

            lista.Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_buscar_questoes_nao_utilizadas()
        {
            //arrange
            PersistirTeste();

            //action
            var questoesNaoUtilizadas = repositorioQuestao.BuscarQuestoesNaoUtilizadas();

            //assert
            questoesNaoUtilizadas.Should().HaveCount(10);

        }


        [TestMethod]
        public void Deve_buscar_questoes_ja_utilizadas()
        {
            //arrange
            PersistirTeste();

            //action
            var questoesNaoUtilizadas = repositorioQuestao.BuscarQuestoesUtilizadas();

            //assert
            questoesNaoUtilizadas.Should().HaveCount(5);
        }

        [TestMethod]
        public void Deve_filtrar_questoes_por_materia()
        {

            // arrange
            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");
            var geometria = PersistirMateria(matematica, "geometria");

            var questao_1 = PersistirQuestao(calculo);
            PersistirQuestao(geometria);

            //action 
            var lista = repositorioQuestao.FiltrarQuestoesPorMateria(questao_1.Materia);

            // assert
            lista.Should().HaveCount(1);

            lista[0].Materia.Nome.Should().Be("calculo");

        }

        [TestMethod]
        public void Deve_editar_questao()
        {
            //arrange

            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");

            var questao = PersistirQuestao(calculo);

            questao.Pergunta = "1234?";

            //action
            repositorioQuestao.Editar(questao);

            //assert
            repositorioQuestao.BuscarPorId(questao.Id)
                .Should()
                .Be(questao);
        }

        [TestMethod]
        public void Deve_excluir_questao()
        {
            //arrange
            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");

            var questao = PersistirQuestao(calculo);

            //action
            repositorioQuestao.Excluir(questao);

            //assert
            repositorioQuestao.BuscarPorId(questao.Id)
                .Should()
                .BeNull();
        }
    }
}
