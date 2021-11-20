using FluentValidation;
using Infra.CrossCutting.ViewModels.Envolvido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class NovoEnvolvidoValidator : AbstractValidator<NovoEnvolvido>
    {
        public NovoEnvolvidoValidator()
        {
            RuleFor(n => n.NomeEnvolvido)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - É campo obrigatório!");

            RuleFor(i => i.IdadeAparente)
                .InclusiveBetween(0, 99)
                    .WithMessage("{PropertyName} - Não pode ser menor que 0 ano ou maior do que 99 anos!");
        }
    }
}
