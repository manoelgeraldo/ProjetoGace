﻿using System.Collections.Generic;

namespace Domain.Entities
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}