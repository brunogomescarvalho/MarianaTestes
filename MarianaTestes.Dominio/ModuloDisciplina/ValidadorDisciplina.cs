﻿using FluentValidation;
using MarianaTestes.Dominio.Compartilhado;

namespace MarianaTestes.Dominio.ModuloDisciplina
{
    public class ValidadorDisciplina : AbstractValidator<Disciplina>, IValidadorDisciplina
    {
        public ValidadorDisciplina() 
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();
        }    
    }
}
