using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoSaudeConfiguration : IEntityTypeConfiguration<EnvolvidoSaude>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoSaude> builder)
        {
            builder.ToTable("SAUDE", "SDS_SIMIP_USU");
            builder.HasKey(c => c.EnvolvidoId);
            builder.Property(c => c.EnvolvidoId).HasColumnName("ENVID");
            builder.Property(c => c.Lesao).HasColumnName("LESAO");
            builder.Property(c => c.OrgaoSocorro).HasColumnName("ORGAOSOCORRO");
            builder.Property(c => c.HospitalSocorro).HasColumnName("HOSPITALSOCORRO");
            builder.Property(d => d.DataObito).HasColumnType("date").HasColumnName("DATAOBITO");
            builder.Property(c => c.HoraMorte).HasColumnName("HORAMORTE");
            builder.Property(c => c.LocalMorte).HasColumnName("LOCALMORTE");
            builder.Property(c => c.UnidadeHospitalar).HasColumnName("UNIDADEHOSPITALAR");
            builder.Property(c => c.NIC).HasColumnName("NIC");
            builder.Property(c => c.RegistroIML).HasColumnName("REGISTROIML");
            builder.Property(c => c.IML).HasColumnName("IML");
            builder.Property(c => c.NumeroDeclaracaoObito).HasColumnName("NUMERODECLARACAOOBITO");
            builder.Property(c => c.GDL).HasColumnName("GDL");
            builder.Property(c => c.SituacaoVitimaAcidente).HasColumnName("SITUACAOVITIMAACIDENTE");
            builder.Property(c => c.TransporteVitima).HasColumnName("TRANSPORTEVITIMA");
            builder.Property(c => c.TransporteAutor).HasColumnName("TRANSPORTEAUTOR");
        }
    }
}
