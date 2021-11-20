using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
