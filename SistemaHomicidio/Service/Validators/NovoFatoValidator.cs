using FluentValidation;
using Infra.CrossCutting.ViewModels;
using System;

namespace Service.Validators
{
    public class NovoFatoValidator : AbstractValidator<NovoFato>
    {
        public NovoFatoValidator()
        {
            RuleFor(d => d.DataFato)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - É campo obrigatório!")
                .LessThanOrEqualTo(DateTime.Now.Date);
        }
    }
}
