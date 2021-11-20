using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoEnderecoConfiguration : IEntityTypeConfiguration<EnvolvidoEndereco>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoEndereco> builder)
        {
            builder.HasKey(c => c.EnvolvidoId);
        }
    }
}
