using System.Collections.Generic;

namespace Infra.CrossCutting.ViewModels.Usuario
{
    public class NovoUsuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public ICollection<ReferenciaFuncao> Funcoes { get; set; }
    }
}
