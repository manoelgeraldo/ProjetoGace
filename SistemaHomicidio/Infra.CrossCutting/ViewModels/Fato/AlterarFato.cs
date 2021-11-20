using Infra.CrossCutting.ViewModels.Auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.ViewModels.Fato
{
    public class AlterarFato
    {
        public int Id { get; set; }
        /// <summary>
        /// Data que ocorreu o fato.
        /// </summary>
        /// <example>01/01/2021</example>.
        public DateTime DataFato { get; set; }

        /// <summary>
        /// Hora que ocorreu o fato.
        /// </summary>
        /// <example>00:00</example>.
        public TimeSpan? HoraFato { get; set; }

        /// <summary>
        /// Turno que ocorreu o fato.
        /// </summary>
        /// <example>NOITE</example>
        public string TurnoFato { get; set; }

        /// <summary>
        /// Natureza do fato.
        /// </summary>
        /// <example>HOMICIDIO</example>
        public string NaturezaBoe { get; set; }

        public string CausaJuridicaFato { get; set; }

        /// <summary>
        /// Motivação inicial do BOE.
        /// </summary>
        /// <example>A DEFINIR</example>
        public string MotivacacaoInicialFato { get; set; }
        /// <summary>
        /// informe o status da motivação.
        /// </summary>
        /// <example>PRELIMINAR</example>
        public string StatusMotivacaoFato { get; set; }
        public string RegiaoFato { get; set; }

        /// <summary>
        /// Informe a cidade que ocorreu o fato.
        /// </summary>
        /// <example>RECIFE</example>.
        public Exibir_Municipio_Diretoria_AIS_BPM MunicipioFato { get; set; }
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

        [NotMapped]
        public long MyTimeSpanSerializer
        {
            get => HoraFato?.Ticks ?? -1;
            set => HoraFato = value >= 0 ? new TimeSpan(value) : null;
        }
    }
}
