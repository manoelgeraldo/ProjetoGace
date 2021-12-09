using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.Property(n => n.BOE).IsRequired().HasMaxLength(13);
            builder.Property(d => d.DataRegistroBOE).HasColumnType("date");
        }
    }
}
