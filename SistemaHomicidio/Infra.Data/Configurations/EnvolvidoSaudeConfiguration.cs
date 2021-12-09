using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoSaudeConfiguration : IEntityTypeConfiguration<EnvolvidoSaude>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoSaude> builder)
        {
            builder.HasKey(c => c.EnvolvidoId);
            builder.Property(d => d.DataObito).HasColumnType("date");
        }
    }
}
