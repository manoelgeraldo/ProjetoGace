using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EnvolvidoEndereco
    {
        public int EnvolvidoId { get; set; }
        public string RegiaoEndereco { get; set; }
        public string MunicipioEndereco { get; set; }
        public string BairroEndereco { get; set; }
        public string LogradouroEndereco { get; set; }
        public string NumeroLogradouroEndereco { get; set; }
        public string ComplementoLogradouroEndereco { get; set; }
        public string PontoReferenciaEndereco { get; set; }
        public string LocalidadeComunidadeEndereco { get; set; }
        public string TipoResidenciaEndereco { get; set; }
        public string LatitudeEndereco { get; set; }
        public string LongitudeEndereco { get; set; }
        public string Fonte { get; set; }
    }
}
