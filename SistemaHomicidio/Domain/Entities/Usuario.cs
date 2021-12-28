using System.Collections.Generic;

namespace Domain.Entities
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public string Funcao { get; set; }
    }
}
