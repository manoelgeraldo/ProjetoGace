using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EnvolvidoCriminal
    {
        public int EnvolvidoId { get; set; }
        public string EnvolvimentoCrime { get; set; }
        public string SituacaoCriminal { get; set; }
        public string ProntuarioSeres { get; set; }
        public string CrimeCometido { get; set; }
        public string SituacaoCarceraria { get; set; }
        public string BoeAntecedente { get; set; }
        public string TipoProcedimento { get; set; }
    }
}
