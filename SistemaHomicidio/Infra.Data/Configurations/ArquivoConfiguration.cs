using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.ToTable("ARQUIVOS", "SDS_SIMIP_USU");
            builder.Property(i => i.Id).ValueGeneratedOnAdd().HasColumnName("ID");
            builder.Property(X => X.NomeArquivo).HasColumnName("NOMEARQUIVO");
            builder.Property(X => X.RegistroId).HasColumnName("RGID");
            builder.Property(X => X.TipoArquivo).HasColumnName("TIPOARQUIVO");
            builder.Property(X => X.DadosArquivo).HasColumnName("DADOSARQUIVO");
            builder.Property(X => X.CriacaoArquivo).HasColumnName("CRIACAOARQUIVO");
        }
    }
}
