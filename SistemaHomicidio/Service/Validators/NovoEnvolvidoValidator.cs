using FluentValidation;
using Infra.CrossCutting.ViewModels.Envolvido;

namespace Service.Validators
{
    public class NovoEnvolvidoValidator : AbstractValidator<NovoEnvolvido>
    {
        public NovoEnvolvidoValidator()
        {
            RuleFor(n => n.NomeEnvolvido)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} - É campo obrigatório!");
        }
    }
}
