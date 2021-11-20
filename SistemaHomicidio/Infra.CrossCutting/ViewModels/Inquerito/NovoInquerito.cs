using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.ViewModels
{
    public class NovoInquerito
    {
        public string NumeroIP { get; set; }
        public string TipoInstauracao { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DataInstaraucao { get; set; }
        public string MotivacaoIP { get; set; }
        public string SituacaoIP { get; set; }
        public int? NumeroOuvida { get; set; }
        public int? NumeroDeclaracao { get; set; }
        public int? NumeroQual { get; set; }
        public string TipoRepresentacao { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DataRepresentacao { get; set; }
        public string NumOfRepresentacao { get; set; }
        public string ExpedicaoMandado { get; set; }
        public string CumprimentoMandado { get; set; }
        public string UnidadePC { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DataConclusao { get; set; }
        public string NumOfRemessa { get; set; }
        public string Destino { get; set; }
        public string AutoridadeResponsavel { get; set; }
        public string MatriculaAutoridadeResponsavel { get; set; }
    }
}
