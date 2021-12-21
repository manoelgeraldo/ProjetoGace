using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class Municipio_Diretoria_AIS_BPMConfiguration : IEntityTypeConfiguration<Municipio_Diretoria_AIS_BPM>
    {
        public void Configure(EntityTypeBuilder<Municipio_Diretoria_AIS_BPM> builder)
        {
            builder.ToTable("MUNICIPIOS");
            builder.HasKey(x => x.Municipio);
            builder.Property(X => X.Municipio).HasColumnName("MUNICIPIO");
            builder.Property(X => X.Diretoria).HasColumnName("DIRETORIA");
            builder.Property(X => X.AIS).HasColumnName("AIS");
            builder.Property(X => X.BPM).HasColumnName("BPM");
        }
    }
}
