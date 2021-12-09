using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class BoeComplementadoConfiguration : IEntityTypeConfiguration<BoeComplementado>
    {
        public void Configure(EntityTypeBuilder<BoeComplementado> builder)
        {
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.DataRegistro).IsRequired().HasColumnType("date");
            builder.Property(d => d.Boe).IsRequired();
        }
    }
}
