using FluentValidation;
using Infra.CrossCutting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
