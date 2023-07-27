using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;

namespace MarianaTestes.TestesUnitarios.ModuloMateria
{
    [TestClass]
    public class MateriaTestes
    {
        Materia operacoesBasicas;

        public MateriaTestes()
        {          
            operacoesBasicas = new Materia("operações básicas", SerieMateriaEnum.Primeira, new Disciplina("Matemática"));
        }

        [TestMethod]
        public void Deve_ser_possivel_adicionar_questoes()
        {
            var questoes = ObterQuestoesParaTeste();

            questoes.ForEach(x => operacoesBasicas.AdicionarQuestoes(x));

            Assert.AreEqual(questoes.Count, operacoesBasicas.Questoes.Count);

        }

        [TestMethod]
        public void Nao_deve_adicionar_questoes_iguais()
        {
            var questoes = ObterQuestoesParaTeste();

            var questaoUm = questoes[0];
           
            operacoesBasicas.AdicionarQuestoes(questaoUm);
            operacoesBasicas.AdicionarQuestoes(questaoUm);

            Assert.AreEqual(1, operacoesBasicas.Questoes.Count);
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


            return new List<Questao>() { questao1,questao2, questao3 };
        }
    }
}

