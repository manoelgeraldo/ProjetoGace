using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSistemaHomicidio.ViewModels.Usuario
{
    public class AlterarUsuario
    {
        [Required(ErrorMessage = "É obrigatório. Informe o nome e o sobrenome!")]
        public string Nome { get; set; }
        public string Login { get; set; }

        [StringLength(7, MinimumLength = 7, ErrorMessage = "Informe uma senha com 7 caracteres!")]
        [Required(ErrorMessage = "É obrigatório!")]
        public string Senha { get; set; }
    }
}
