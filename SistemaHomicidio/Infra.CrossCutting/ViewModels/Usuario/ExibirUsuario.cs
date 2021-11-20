using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.ViewModels.Usuario
{
    public class ExibirUsuario
    {
        public string Nome { get; set; }

        public ICollection<ExibirFuncao> Funcoes { get; set; }

        public string Token { get; set; }
    }
}
