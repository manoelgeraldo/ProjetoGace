using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<ReferenciaFuncao> Funcoes { get; set; }
    }
}
