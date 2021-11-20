using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(l => l.Login).Length(11).NotEmpty().NotNull().WithMessage("Informe o Login!");
            RuleFor(s => s.Senha).Length(7).NotEmpty().NotNull().WithMessage("Informe a Senha!");
        }  
    }
}
