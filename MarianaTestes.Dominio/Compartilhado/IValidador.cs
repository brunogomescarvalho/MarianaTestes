using FluentValidation.Results;


namespace MarianaTestes.Dominio.Compartilhado
{
    public interface IValidador<T> where T : EntidadeBase<T>
    {
        public ValidationResult Validate(T instance);

    }
}
