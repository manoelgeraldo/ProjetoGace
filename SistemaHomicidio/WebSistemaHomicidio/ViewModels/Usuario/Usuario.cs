using System.Collections.Generic;

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
