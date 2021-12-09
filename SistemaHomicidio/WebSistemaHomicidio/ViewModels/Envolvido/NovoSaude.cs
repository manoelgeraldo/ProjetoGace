using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSistemaHomicidio.ViewModels.Envolvido
{
    public class NovoSaude
    {
        public string Lesao { get; set; }
        public string OrgaoSocorro { get; set; }
        public string HospitalSocorro { get; set; }
        public DateTime? DataObito { get; set; }
        public TimeSpan? HoraMorte { get; set; }
        public string LocalMorte { get; set; }
        public string UnidadeHospitalar { get; set; }
        public string NIC { get; set; }
        public string RegistroIML { get; set; }
        public string IML { get; set; }
        public string NumeroDeclaracaoObito { get; set; }
        public string GDL { get; set; }
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
