using FluentAssertions;
using FluentValidation.TestHelper;
using MarianaTestes.Dominio.ModuloDisciplina;

namespace MarianaTestes.TestesUnitarios.ModuloDisciplina
{
    [TestClass]

    public class DisciplinaTestesValidadores
    {
        Disciplina disciplina;
        ValidadorDisciplina validador;

        public DisciplinaTestesValidadores()
        {
            disciplina = new Disciplina();
            validador = new ValidadorDisciplina();
        }

        [TestMethod]
        public void Nome_disciplina_nao_pode_ser_nulo_ou_vazio()
        {
            var resultado = validador.TestValidate(disciplina);

            resultado.ShouldHaveValidationErrorFor(x => x.Nome);
        }

        [TestMethod]
        public void Nome_disciplina_deve_ter_minimo_3_caracteres()
        {
            disciplina.Nome = "ab";

            var resultado = validador.TestValidate(disciplina);

            resultado.ShouldHaveValidationErrorFor(x => x.Nome);
        }

        [TestMethod]
        public void Nome_disciplina_nao_deve_conter_caracteres_especiais()
        {
            disciplina.Nome = "artes @";

            var resultado = validador.TestValidate(disciplina);

            resultado.ShouldHaveValidationErrorFor(x => x.Nome);
        }

        [TestMethod]
        public void Nome_disciplina_deve_ser_maior_3_caracteres()
        {
            disciplina.Nome = "Matemática";

            var resultado = validador.TestValidate(disciplina);

            resultado.IsValid.Should().Be(true);
        }
    }
}
