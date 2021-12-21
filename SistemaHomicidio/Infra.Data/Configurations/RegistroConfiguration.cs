using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("REGISTROS", "SDS_SIMIP_USU");
            builder.Property(n => n.Id).HasColumnName("ID");
            builder.Property(n => n.BOE).IsRequired().HasMaxLength(13).HasColumnName("BOE");
            builder.Property(d => d.DataRegistroBOE).HasColumnType("date").HasColumnName("DATAREGISTROBOE");
            builder.Property(n => n.TipoDeRegistro).HasColumnName("TIPODEREGISTRO");
            builder.Property(n => n.Intencionalidade).HasColumnName("INTENCIONALIDADE");
            builder.Property(n => n.DataLancamento).HasColumnName("DATALANCAMENTO");
            builder.Property(n => n.DataAtualizacao).HasColumnName("DATAATUALIZACAO");
            builder.Property(n => n.ObservacaoRegistro).HasColumnName("OBSERVACAOREGISTRO");
            builder.Property(n => n.StatusRegistro).HasColumnName("STATUSREGISTRO");
            builder.Property(n => n.UsuarioRegistro).HasColumnName("USUARIOREGISTRO");
            builder.Property(n => n.Excluido).HasColumnName("EXCLUIDO");
        }
    }
}
