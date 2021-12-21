using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoEnderecoConfiguration : IEntityTypeConfiguration<EnvolvidoEndereco>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoEndereco> builder)
        {
            builder.ToTable("ENDERECOS", "SDS_SIMIP_USU");
            builder.HasKey(c => c.EnvolvidoId);
            builder.Property(X => X.EnvolvidoId).HasColumnName("ENVID");
            builder.Property(X => X.RegiaoEndereco).HasColumnName("REGIAOENDERECO");
            builder.Property(X => X.MunicipioEndereco).HasColumnName("MUNICIPIOENDERECO");
            builder.Property(X => X.BairroEndereco).HasColumnName("BAIRROENDERECO");
            builder.Property(X => X.LogradouroEndereco).HasColumnName("LOGRADOUROENDERECO");
            builder.Property(X => X.NumeroLogradouroEndereco).HasColumnName("NUMEROLOGRADOUROENDERECO");
            builder.Property(X => X.ComplementoLogradouroEndereco).HasColumnName("COMPLEMENTOLOGRADOUROENDERECO");
            builder.Property(X => X.PontoReferenciaEndereco).HasColumnName("PONTOREFERENCIAENDERECO");
            builder.Property(X => X.LocalidadeComunidadeEndereco).HasColumnName("LOCALIDADECOMUNIDADEENDERECO");
            builder.Property(X => X.TipoResidenciaEndereco).HasColumnName("TIPORESIDENCIAENDERECO");
            builder.Property(X => X.LatitudeEndereco).HasColumnName("LATITUDEENDERECO");
            builder.Property(X => X.LongitudeEndereco).HasColumnName("LONGITUDEENDERECO");
            builder.Property(X => X.Fonte).HasColumnName("FONTE");
        }
    }
}
