using System.ComponentModel.DataAnnotations;

namespace WebSistemaHomicidio.ViewModels.Usuario
{
    public class NovoUsuario
    {
        [Required(ErrorMessage = "É obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "É obrigatório!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É obrigatório!")]
        public string Funcao { get; set; }
    }
}
