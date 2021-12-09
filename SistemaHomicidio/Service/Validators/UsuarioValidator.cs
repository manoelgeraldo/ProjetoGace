using Domain.Entities;
using FluentValidation;

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
