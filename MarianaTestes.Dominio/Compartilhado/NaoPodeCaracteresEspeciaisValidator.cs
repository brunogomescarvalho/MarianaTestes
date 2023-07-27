using FluentValidation;
using FluentValidation.Validators;


namespace MarianaTestes.Dominio.Compartilhado
{
    public class NaoPodeCaracteresEspeciaisValidator<T> : PropertyValidator<T,string> 
    {
        public override string Name => "NaoPodeCaracteresEspeciaisValidator";

        private string nomePropriedade = string.Empty;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve ser composto por letras e números.";
        }

        public override bool IsValid(ValidationContext<T> context, string nome)
        {
            nomePropriedade = context.DisplayName;

            bool temCaracteresInvalidos = false;

            foreach (char letra in nome)
            {
                if (letra == ' ')
                    continue;

                if (char.IsLetterOrDigit(letra) == false)
                {
                    temCaracteresInvalidos = true;
                    break;
                }               
            }

            return !temCaracteresInvalidos;
        }
    }
}
