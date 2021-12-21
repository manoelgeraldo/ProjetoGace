using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class BoeComplementadoConfiguration : IEntityTypeConfiguration<BoeComplementado>
    {
        public void Configure(EntityTypeBuilder<BoeComplementado> builder)
        {
            builder.ToTable("BOECOMPL", "SDS_SIMIP_USU");
            builder.Property(i => i.Id).ValueGeneratedOnAdd().HasColumnName("ID");
            builder.Property(d => d.DataRegistro).IsRequired().HasColumnType("date").HasColumnName("DATAREGISTRO");
            builder.Property(d => d.Boe).IsRequired().HasColumnName("BOE");
            builder.Property(X => X.RegistroId).HasColumnName("RGID");
        }
    }
}
