using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoCriminalConfiguration : IEntityTypeConfiguration<EnvolvidoCriminal>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoCriminal> builder)
        {
            builder.ToTable("CRIMINAL", "SDS_SIMIP_USU");
            builder.HasKey(c => c.EnvolvidoId);
            builder.Property(X => X.EnvolvidoId).HasColumnName("ENVID");
            builder.Property(X => X.EnvolvimentoCrime).HasColumnName("ENVOLVIMENTOCRIME");
            builder.Property(X => X.SituacaoCriminal).HasColumnName("SITUACAOCRIMINAL");
            builder.Property(X => X.ProntuarioSeres).HasColumnName("PRONTUARIOSERES");
            builder.Property(X => X.CrimeCometido).HasColumnName("CRIMECOMETIDO");
            builder.Property(X => X.SituacaoCarceraria).HasColumnName("SITUACAOCARCERARIA");
            builder.Property(X => X.BoeAntecedente).HasColumnName("BOEANTECEDENTE");
            builder.Property(X => X.TipoProcedimento).HasColumnName("TIPOPROCEDIMENTO");
        }
    }
}
