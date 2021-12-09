using System.Collections.Generic;

namespace WebSistemaHomicidio.ViewModels.Usuario
{
    public class ExibirUsuario
    {
        public string Nome { get; set; }

        public ICollection<ExibirFuncao> Funcoes { get; set; }

        public string Token { get; set; }
    }
}
