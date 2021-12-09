using System;

namespace WebSistemaHomicidio.ViewModels.Arquivo
{
    public class NovoArquivo
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }
        public string NomeArquivo { get; set; }
        public string TipoArquivo { get; set; }
        public byte[] DadosArquivo { get; set; }
        public DateTime? CriacaoArquivo { get; set; }
    }
}
