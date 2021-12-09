using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(k => k.Login);
            builder.Property(n => n.Nome).IsRequired();
            builder.Property(l => l.Login).IsRequired();
            builder.Property(s => s.Senha).IsRequired();
        }
    }
}
