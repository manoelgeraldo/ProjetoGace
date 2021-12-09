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

            RuleFor(i => i.IdadeAparente)
                .InclusiveBetween(0, 99)
                    .WithMessage("{PropertyName} - Não pode ser menor que 0 ano ou maior do que 99 anos!");
        }
    }
}
