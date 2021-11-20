﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Arquivo
    {
        public int? Id { get; set; }
        public int RegistroId { get; set; }
        public string NomeArquivo { get; set; }
        public string TipoArquivo { get; set; }
        public byte[] DadosArquivo { get; set; }
        public DateTime? CriacaoArquivo { get; set; }
    }
}
