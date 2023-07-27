using FluentValidation;
using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {

            RuleFor(i => i.Disciplina)
              .NotNull();

            RuleFor(i => i.Nome)
                .NotEmpty()
                .MinimumLength(3)
                .NotNull()
                .NaoPodeCaracteresEspeciais();

            RuleFor(i => i.Serie)
                .NotNull();
        }
    }
}
