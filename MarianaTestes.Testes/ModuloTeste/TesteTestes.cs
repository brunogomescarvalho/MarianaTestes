using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;
using MarianaTestes.Dominio.ModuloTeste;

namespace MarianaTestes.TestesUnitarios.ModuloTeste
{
    [TestClass]
    public class TesteTestes
    {
        Materia operacoesBasicas;

        public TesteTestes()
        {
            operacoesBasicas = new Materia("operações básicas", SerieMateriaEnum.Primeira, new Disciplina("Matemática"));
        }

        [TestMethod]
        public void Nao_deve_incluir_questoes_repetidas_ao_sortear_randomicamente()
        {
            var questoes = ObterQuestoesParaTeste();

            var teste = new Teste();

            teste.ObterQuestoesSorteadas(questoes, 3);

            var lista = teste.Questoes.GroupBy(x => x);

            bool repetido = false;

            if (lista.Any(x => x.Count() > 1))
            {
                repetido = true;
            }

            Assert.IsFalse(repetido);
        }

        [TestMethod]
        public void Deve_conter_4_questoes()
        {
            var questoes = ObterQuestoesParaTeste();

            var teste = new Teste();

            teste.ObterQuestoesSorteadas(questoes, 4);

            Assert.AreEqual(4, teste.Questoes.Count);
        }

        [TestMethod]
        public void Deve_enviar_mensagem_se_lista_conter_menos_questoes_que_solicitado()
        {
            var lista = ObterQuestoesParaTeste();

            var teste = new Teste();

            teste.InformarQtdInsuficiente += Teste_InformarQtdInsuficiente;

            teste.ObterQuestoesSorteadas(lista, 12);

          
        }

        private void Teste_InformarQtdInsuficiente(string msg)
        {
            Assert.AreEqual($"A quantidade de questões solicitada: '12', é superior a disponível: '6'", msg);
        }

        private List<Questao> ObterQuestoesParaTeste()
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

            Questao questao4 = new Questao("5 * 3 ?", operacoesBasicas);

            questao4.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("13", false),
                new Alternativa("14", false),
                new Alternativa("15", true),
                new Alternativa("16", false), });

            Questao questao5 = new Questao("8 * 3 ?", operacoesBasicas);

            questao5.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("23", false),
                new Alternativa("22", false),
                new Alternativa("20", false),
                new Alternativa("21", true), });

            Questao questao6 = new Questao("12 x 2 ?", operacoesBasicas);

            questao6.Alternativas.AddRange(new Alternativa[] {
                new Alternativa("23", false),
                new Alternativa("24", true),
                new Alternativa("25", false),
                new Alternativa("26", false), });


            return new List<Questao>() { questao1, questao2, questao3, questao4, questao5, questao6 };
        }
    }
}
