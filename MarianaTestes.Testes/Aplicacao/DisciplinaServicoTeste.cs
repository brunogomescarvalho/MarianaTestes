
using FluentAssertions;
using FluentResults.Extensions.FluentAssertions;
using FluentValidation.Results;
using MarianaTestes.Aplicacao.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloDisciplina;
using Moq;
using System.Data.SqlClient;

namespace MarianaTestes.TestesUnitarios.Aplicacao
{
    [TestClass]

    public class DisciplinaServicoTeste
    {

        Mock<IRepositorioDisciplina> repositorioDisciplinaMoq;
        Mock<IValidadorDisciplina> validadorDisciplinaMoq;
        ServicoDisciplina servicoDisciplina;


        public DisciplinaServicoTeste()
        {
            repositorioDisciplinaMoq = new Mock<IRepositorioDisciplina>();
            validadorDisciplinaMoq = new Mock<IValidadorDisciplina>();
            servicoDisciplina = new ServicoDisciplina(repositorioDisciplinaMoq.Object, validadorDisciplinaMoq.Object);
        }

        [TestMethod]
        public void Se_disciplina_for_valida_entao_deve_cadastrar()
        {
            var disciplina = new Disciplina("Artes");

            var resultado = servicoDisciplina.Inserir(disciplina);

            resultado.Should().BeSuccess();

            repositorioDisciplinaMoq.Verify(x => x.Cadastrar(disciplina), Times.Once);
        }

        [TestMethod]
        public void Se_disciplina_conter_caracteres_nao_deve_cadastrar()
        {
            validadorDisciplinaMoq.Setup(x => x.Validate(It.IsAny<Disciplina>()))
                .Returns(() =>
                {
                    var resultado = new ValidationResult();
                    resultado.Errors.Add(new ValidationFailure("Nome", "'Nome' deve ser composto por letras e números."));
                    return resultado;
                });

            var disciplina = new Disciplina("@@@");

            var resultado = servicoDisciplina.Inserir(disciplina);

            resultado.Should().BeFailure();

            repositorioDisciplinaMoq.Verify(x => x.Cadastrar(disciplina), Times.Never);
        }

        [TestMethod]
        public void Se_disciplina_ja_existir_nao_deve_cadastrar()
        {
            repositorioDisciplinaMoq.Setup(x => x.BuscarDisciplinaPorNome("Artes"))
                .Returns(() => new Disciplina(2, "Artes", new()));

            validadorDisciplinaMoq.Setup(x => x.Validate(It.IsAny<Disciplina>()))
                .Returns(() => new ValidationResult());

            var disciplina = new Disciplina("Artes");

            var result = servicoDisciplina.Inserir(disciplina);

            result.Should().BeFailure();

            repositorioDisciplinaMoq.Verify(x => x.Cadastrar(disciplina), Times.Never);
        }


        [TestMethod]
        public void Deve_enviar_excessao_ao_falhar()
        {
            repositorioDisciplinaMoq.Setup(x => x.Cadastrar(It.IsAny<Disciplina>()))
                .Throws(new Exception());

            var disciplina = new Disciplina("Teste");

            var result = servicoDisciplina.Inserir(disciplina);

            result.Should().As<Exception>();

            repositorioDisciplinaMoq.Verify(x => x.Cadastrar(disciplina), Times.Once);

        }

        
    }
}
