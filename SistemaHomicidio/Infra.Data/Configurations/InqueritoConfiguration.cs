using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class InqueritoConfiguration : IEntityTypeConfiguration<Inquerito>
    {
        public void Configure(EntityTypeBuilder<Inquerito> builder)
        {
            builder.HasKey(c => c.RegistroId);
            builder.Property(d => d.DataConclusao).HasColumnType("date");
            builder.Property(d => d.DataInstaraucao).HasColumnType("date");
            builder.Property(d => d.DataRepresentacao).HasColumnType("date");
        }
    }
}
