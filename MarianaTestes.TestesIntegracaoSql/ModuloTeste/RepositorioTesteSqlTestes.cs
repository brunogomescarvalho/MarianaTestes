using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;
using MarianaTestes.TestesIntegracaoSql.Compartilhado;
using System.Data.SqlClient;

namespace MarianaTestes.TestesIntegracaoSql.ModuloTeste
{
    [TestClass]
    public class RepositorioTesteSqlTestes : TesteIntegracaoBase
    {
        Materia operacoesBasicas;

        Materia geometria;

        Disciplina matematica;

        Teste teste;

        public RepositorioTesteSqlTestes():base()
        {

           

            matematica = new Disciplina("Matemática");

            repositorioDisciplina.Cadastrar(matematica);

            operacoesBasicas = new Materia("Operações Básicas", SerieMateriaEnum.Primeira, matematica);
   
            geometria = new Materia("Geometria", SerieMateriaEnum.Primeira, matematica);

            matematica.AdicionarMateria(operacoesBasicas);

            matematica.AdicionarMateria(geometria);

            repositorioMateria.Cadastrar(operacoesBasicas);

            repositorioMateria.Cadastrar(geometria);

            ObterQuestoes().ForEach(i => repositorioQuestao.Cadastrar(i));
        }

        [TestMethod]
        public void Deve_cadastrar_testes()
        {
            CriarObjetoTeste();

            repositorioTeste.Cadastrar(teste);

            var testes = repositorioTeste.BuscarTodos(carregarQuestoes: true);

            Teste testeCadastrado = testes[0];

            Assert.AreEqual(teste, testeCadastrado);

            Assert.AreEqual(1, testes.Count);

        }


        [TestMethod]
        public void Ao_cadastrar_teste_recuperacao_deve_conter_questoes_de_todas_as_materias_da_serie_e_disciplina()
        {
            var listaQuestoesRecuperacao = repositorioQuestao.BuscarQuestoesProvaRecuperacao(1, SerieMateriaEnum.Primeira);

            teste = new Teste
            {
                Titulo = "Teste Recuperacao Matematica",
                Recuperacao = true,
                Disciplina = matematica,
                Materia = null!,
                DataTeste = DateTime.Now,
                Serie = SerieMateriaEnum.Primeira,

            };
            teste.ObterQuestoesSorteadas(listaQuestoesRecuperacao, 5);

            repositorioTeste.Cadastrar(teste);

            Teste testeCadastrado = repositorioTeste.BuscarPorId(1);

            var contemGeometria = testeCadastrado.Questoes.Any(x => x.Materia.Equals(geometria));

            var contemOperacoesBasicas = testeCadastrado.Questoes.Any(x => x.Materia.Equals(operacoesBasicas));

            Assert.IsTrue(contemGeometria);

            Assert.IsTrue(contemOperacoesBasicas);

        }

        [TestMethod]
        public void Deve_excluir_teste()
        {
            CriarObjetoTeste();

            repositorioTeste.Cadastrar(teste);

            repositorioTeste.Excluir(teste);

            int count = repositorioTeste.BuscarTodos().Count;

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Deve_filtrar_teste_por_materia()
        {
            CriarObjetoTeste();

            repositorioTeste.Cadastrar(teste);

            var filtro = new FiltroTeste
            {
                Tipo = FiltroDeTeste.Materia,
                Id = 1
            };

            var testeDeOpracaoBasica = repositorioTeste.FiltrarTestes(filtro);

            Assert.AreEqual(operacoesBasicas, testeDeOpracaoBasica[0].Materia);
        }


        private void CriarObjetoTeste()
        {
            var materiaDoTeste = repositorioMateria.BuscarPorId(1);

            teste = new Teste()
            {
                Titulo = "Novo Teste Matematica",
                Disciplina = materiaDoTeste.Disciplina,
                Materia = materiaDoTeste,
                Serie = materiaDoTeste.Serie,
                DataTeste = DateTime.Now,
                Recuperacao = false,
                QtdQuestoes = 3
            };

            teste.ObterQuestoesSorteadas(materiaDoTeste.Questoes, 3);
        }

        private List<Questao> ObterQuestoes()
        {
            Questao questao1 = new Questao("9 / 3 ?", operacoesBasicas);

            questao1.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("3", true),
                new Alternativa("4", false),
                new Alternativa("5", false),
                new Alternativa("6", false), });

            Questao questao2 = new Questao("3 + 3 ?", operacoesBasicas);

            questao2.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("3", false),
                new Alternativa("4", false),
                new Alternativa("5", false),
                new Alternativa("6", true), });

            Questao questao3 = new Questao("2 x 2 ?", operacoesBasicas);

            questao3.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("3", false),
                new Alternativa("4", true),
                new Alternativa("5", false),
                new Alternativa("6", false), });

            Questao questao4 = new Questao("Qual forma tem tres lados ?", geometria);

            questao4.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("quadrado", false),
                new Alternativa("circulo", false),
                new Alternativa("triangulo", true),
                new Alternativa("pentagono", false), });

            Questao questao5 = new Questao("Qual forma tem quatro lados?", geometria);

            questao5.Alternativas.AddRange(new Alternativa[] {
               new Alternativa("quadrado", true),
                new Alternativa("circulo", false),
                new Alternativa("triangulo", false),
                new Alternativa("pentagono", false), });

            Questao questao6 = new Questao("Qual forma tem cinco lados?", geometria);

            questao6.Alternativas.AddRange(new Alternativa[] {
              new Alternativa("quadrado", false),
                new Alternativa("circulo", false),
                new Alternativa("triangulo", false),
                new Alternativa("pentagono", true), });

            return new List<Questao>() { questao1, questao2, questao3, questao4, questao5, questao6 };
        }

       
    }
}
