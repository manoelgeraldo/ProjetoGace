﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSistemaHomicidio.ViewModels.Arquivo
{
    public class NovoArquivo
    {
        public int RegistroId { get; set; }
        public string NomeArquivo { get; set; }
        public string TipoArquivo { get; set; }
        public byte[] DadosArquivo { get; set; }
        public DateTime? CriacaoArquivo { get; set; }
    }
}
