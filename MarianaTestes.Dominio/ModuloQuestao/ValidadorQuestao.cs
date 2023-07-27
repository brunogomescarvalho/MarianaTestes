using FluentValidation;
using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(i => i.Materia)
               .NotNull();

            RuleFor(i => i.Pergunta)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleForEach(i => i.Alternativas)
                .NotEmpty()
                .NotNull();

            RuleFor(i => i.Alternativas)
                .Must(Alternativas => Alternativas.Count <= 4 && Alternativas.Count >= 2)
                .WithMessage("Cada questão deve conter entre 2 e 4 alternativas")

                .Must(Alternativas => Alternativas.Count(i => i.EhCorreta == true) == 1)
                .WithMessage(i =>
                {
                    int count = i.Alternativas.Count(i => i.EhCorreta == true);

                    return $"Selecione {(count > 1 ? "apenas " : "")} uma alternativa correta";

                });

        }
    }
}
