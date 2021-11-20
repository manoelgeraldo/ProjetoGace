using FluentValidation;
using Infra.CrossCutting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class NovoRegistroValidator : AbstractValidator<NovoRegistro>
    {
        public NovoRegistroValidator()
        {
            RuleFor(d => d.DataRegistroBOE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - Campo obrigatório!")
                .LessThanOrEqualTo(DateTime.Now.Date);
           
            RuleFor(b => b.BOE)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - Campo obrigatório!")
                .Length(13).WithMessage("{PropertyName} - Deve possuir 13 caracteres!");

            RuleFor(t => t.TipoDeRegistro)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - Campo obrigatório!");
        }
    }
}
