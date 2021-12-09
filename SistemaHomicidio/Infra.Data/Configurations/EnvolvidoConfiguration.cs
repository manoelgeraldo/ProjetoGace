using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoConfiguration : IEntityTypeConfiguration<Envolvido>
    {
        public void Configure(EntityTypeBuilder<Envolvido> builder)
        {
            builder.Property(i => i.Id);
            builder.Property(d => d.DataNascimento).HasColumnType("date");
        }
    }
}
