using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime DataRegistroBOE { get; set; }
        public string BOE { get; set; }
        public string TipoDeRegistro { get; set; }
        public string Intencionalidade { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string ObservacaoRegistro { get; set; }
        public bool StatusRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        //Navegação
        public Fato Fato { get; set; }
        public List<Envolvido> Envolvidos { get; set; }
        public Inquerito Inquerito { get; set; }
        public List<Arquivo> Arquivos { get; set; }
        public List<BoeComplementado> BoeComplementados { get; set; }
    }
}
