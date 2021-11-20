using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.CrossCutting.ViewModels.Envolvido
{
    public class NovoSaude
    {
        public string Lesao { get; set; }
        public string OrgaoSocorro { get; set; }
        public string HospitalSocorro { get; set; }

        /// <summary>
        /// Data que ocorreu o óbito.
        /// </summary>
        /// <example>01/01/2021</example>
        public DateTime? DataObito { get; set; }

        /// <summary>
        /// Hora que ocorreu o óbito.
        /// </summary>
        /// <example>00:00</example>
        public TimeSpan? HoraMorte { get; set; }
        public string LocalMorte { get; set; }
        public string UnidadeHospitalar { get; set; }
        public string NIC { get; set; }
        public string RegistroIML { get; set; }
        public string IML { get; set; }
        public string NumeroDeclaracaoObito { get; set; }
        public string GDL { get; set; }
        public string MotivacaoInicial { get; set; }
        public string MotivacaoFinal { get; set; }
        public string SituacaoVitimaAcidente { get; set; }
        public string TransporteVitima { get; set; }
        public string TransporteAutor { get; set; }

        [NotMapped]
        public long MyTimeSpanSerializer
        {
            get => HoraMorte?.Ticks ?? -1;
            set => HoraMorte = value >= 0 ? new TimeSpan(value) : null;
        }
    }
}
