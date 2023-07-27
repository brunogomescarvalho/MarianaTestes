

using FluentValidation;
using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(i => i.DataTeste)
               .NotNull();

            RuleFor(i => i.Titulo)
                .NotNull()
                .Length(3, 20)
                .NaoPodeCaracteresEspeciais(); 

            RuleFor(i => i.Disciplina)
                .NotNull();

            RuleFor(i => i.Materia)
                .NotNull()
                .When(i => i.Recuperacao == false);

            RuleFor(i => i.Serie)
                .NotNull();

            RuleFor(i => i.Questoes)
                .Must(Questoes => Questoes.Count >= 2)
                .WithMessage("Para gerar um teste é necessário ao menos duas questões");

        }
    }
}
