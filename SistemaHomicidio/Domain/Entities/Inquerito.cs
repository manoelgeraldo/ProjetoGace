using System;

namespace Domain.Entities
{
    public class Inquerito
    {
        public int RegistroId { get; set; }
        public string NumeroIP { get; set; }
        public string TipoInstauracao { get; set; }
        public DateTime? DataInstaraucao { get; set; }
        public string SituacaoIP { get; set; }
        public int? NumeroOuvida { get; set; }
        public int? NumeroDeclaracao { get; set; }
        public int? NumeroQual { get; set; }
        public string TipoRepresentacao { get; set; }
        public DateTime? DataRepresentacao { get; set; }
        public string NumOfRepresentacao { get; set; }
        public string ExpedicaoMandado { get; set; }
        public string CumprimentoMandado { get; set; }
        public string UnidadePC { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string NumOfRemessa { get; set; }
        public string Destino { get; set; }
        public string AutoridadeResponsavel { get; set; }
        public string MatriculaAutoridadeResponsavel { get; set; }
    }
}
