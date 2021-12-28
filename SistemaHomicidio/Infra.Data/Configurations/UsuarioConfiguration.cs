using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO","SDS_SIMIP_USU");
            builder.HasKey(k => k.Login);
            builder.Property(l => l.Login).IsRequired().HasColumnName("LOGIN");
            builder.Property(n => n.Nome).IsRequired().HasColumnName("NOME");
            builder.Property(s => s.Senha).IsRequired().HasColumnName("SENHA");
            builder.Property(x => x.Funcao).IsRequired().HasColumnName("FUNCAO");
        }
    }
}