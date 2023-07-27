using FizzWare.NBuilder;
using FluentAssertions;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.TestesIntegracaoSql.Compartilhado;
using System.Data.SqlClient;

namespace MarianaTestes.TestesIntegracaoSql.ModuloDisciplina
{
    [TestClass]

    public class RepositorioDisciplinaSqlTeste : TesteIntegracaoBase
    {

        [TestMethod]
        public void Deve_cadastrar_disciplina()
        {
            var disciplina = Builder<Disciplina>.CreateNew().Persist();

            var lista = repositorioDisciplina.BuscarTodos();

            lista[0].Should().Be(disciplina);

            lista.Should().HaveCount(1);

        }

        [TestMethod]
        public void Deve_buscar_disciplinas_com_materias()
        {
            var matematica = PersisitirDisciplina("matematica");

            var calculo = PersistirMateria(matematica, "calculo");
            var geometria = PersistirMateria(matematica, "geometria");

            var disciplinas = repositorioDisciplina.BuscarTodos(buscarMaterias: true);

            disciplinas.Should().HaveCount(1);

            disciplinas[0].Materias.Should().ContainInOrder(calculo, geometria);

        }

    
    }
}
