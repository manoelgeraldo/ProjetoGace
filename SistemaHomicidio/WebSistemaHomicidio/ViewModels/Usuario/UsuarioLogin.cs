using System.ComponentModel.DataAnnotations;

namespace WebSistemaHomicidio.ViewModels.Usuario
{
    public class UsuarioLogin
    {
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Formato inválido!")]
        [Required(ErrorMessage = "É obrigatório!")]
        public string Login { get; set; }

        [StringLength(7, MinimumLength = 7, ErrorMessage = "Formato inválido!")]
        [Required(ErrorMessage = "É obrigatório!")]
        public string Senha { get; set; }
    }
}
