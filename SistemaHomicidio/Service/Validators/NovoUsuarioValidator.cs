using FluentValidation;
using Infra.CrossCutting.ViewModels.Usuario;

namespace Service.Validators
{
    public class NovoUsuarioValidator : AbstractValidator<NovoUsuario>
    {
        public NovoUsuarioValidator()
        {
            RuleFor(l => l.Login).Length(11).NotEmpty().NotNull();
            RuleFor(s => s.Senha).Length(7).NotEmpty().NotNull();
            RuleFor(f => f.Funcoes).NotEmpty().NotNull();
        }
    }
}
