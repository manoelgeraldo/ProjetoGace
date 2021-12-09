using System.Collections.Generic;

namespace Infra.CrossCutting.ViewModels.Usuario
{
    public class ExibirUsuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }

        public ICollection<ExibirFuncao> Funcoes { get; set; }

        public string Token { get; set; }
    }
}
