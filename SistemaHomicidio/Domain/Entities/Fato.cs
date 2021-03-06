using System;

namespace Domain.Entities
{
    public class Fato
    {
        public int RegistroId { get; set; }
        public DateTime DataFato { get; set; }
        public string DiaSemanaAbreviadoFato { get; set; }
        public int DiaNumeralFato { get; set; }
        public TimeSpan? HoraFato { get; set; }
        public string TurnoFato { get; set; }
        public string NaturezaBoe { get; set; }
        public string CausaJuridicaFato { get; set; }
        public string StatusMotivacaoFato { get; set; }
        public string RegiaoFato { get; set; }
        public string MunicipioFato { get; set; }
        public string BairroFato { get; set; }
        public string LogradouroFato { get; set; }
        public string NumeroLogradouroFato { get; set; }
        public string ComplementoFato { get; set; }
        public string PontoReferenciaFato { get; set; }
        public string LocalidadeComunidadeFato { get; set; }
        public string LocalFato { get; set; }
        public string ZonaFato { get; set; }
        public string DiretoriaFato { get; set; }
        public string AisFato { get; set; }
        public string UnidadePMFato { get; set; }
        public string UnidadePCFato { get; set; }
        public string LatitudeFato { get; set; }
        public string LongitudeFato { get; set; }
        public string FonteFato { get; set; }
        public string HistoricoFato { get; set; }
    }
}
