using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSistemaHomicidio.ViewModels.Usuario
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }

        public ICollection<Funcao> Funcoes { get; set; }

        public Usuario()
        {
            Funcoes = new HashSet<Funcao>();
        }
    }
}
