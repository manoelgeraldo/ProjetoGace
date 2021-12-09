using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoCriminalConfiguration : IEntityTypeConfiguration<EnvolvidoCriminal>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoCriminal> builder)
        {
            builder.HasKey(c => c.EnvolvidoId);
        }
    }
}
