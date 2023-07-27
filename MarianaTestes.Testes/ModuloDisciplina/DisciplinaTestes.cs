using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarianaTestes.TestesUnitarios.ModuloDisciplina
{
    [TestClass]
    public class DisciplinaTestes
    {
        Disciplina matematica;

        public DisciplinaTestes() 
        {
            matematica = new Disciplina("Matemática", new List<Materia>());
        }

        [TestMethod]
        public void Deve_permitir_adicionar_materias_na_disciplina()
        {
            //Cenário -- Arrange
            Materia adiciaoDezenas = new Materia("Adição de Dezenas", SerieMateriaEnum.Primeira, matematica);
            Materia adiciaoUnidades = new Materia("Adição de Unidades", SerieMateriaEnum.Primeira, matematica);

            //Ação -- Action
            matematica.AdicionarMateria(adiciaoDezenas);
            matematica.AdicionarMateria(adiciaoUnidades);

            //Verificação -- Assert
            Assert.AreEqual(2, matematica.Materias.Count);
        }


        [TestMethod]
        public void Nao_deve_permitir_adicionar_materias_ja_cadastradas()
        {
            //Cenário -- Arrange
            Materia adiciaoDezenas = new Materia("Adição de Dezenas", SerieMateriaEnum.Primeira, matematica);

            //Ação -- Action
            matematica.AdicionarMateria(adiciaoDezenas);
            matematica.AdicionarMateria(adiciaoDezenas);

            //Verificação -- Assert
            Assert.AreEqual(1, matematica.Materias.Count);
        }

        [TestMethod]
        public void Deve_permitir_editar_nome_disciplina()
        {
            string nomeDisciplina = "matemática_editada";

            Disciplina disciplinaEditada = new Disciplina(nomeDisciplina);

            matematica.Editar(disciplinaEditada);

            Assert.AreEqual(nomeDisciplina, matematica.Nome);
        }

    }

}

