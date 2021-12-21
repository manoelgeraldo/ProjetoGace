using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class InqueritoConfiguration : IEntityTypeConfiguration<Inquerito>
    {
        public void Configure(EntityTypeBuilder<Inquerito> builder)
        {
            builder.ToTable("INQUERITOS", "SDS_SIMIP_USU");
            builder.HasKey(c => c.RegistroId);
            builder.Property(c => c.RegistroId).HasColumnName("RGID");
            builder.Property(c => c.NumeroIP).HasColumnName("NUMEROIP");
            builder.Property(c => c.TipoInstauracao).HasColumnName("TIPOINSTAURACAO");
            builder.Property(d => d.DataInstaraucao).HasColumnType("date").HasColumnName("DATAINSTAURACAO");
            builder.Property(c => c.SituacaoIP).HasColumnName("SITUACAOIP");
            builder.Property(c => c.NumeroOuvida).HasColumnName("NUMEROOUVIDA");
            builder.Property(c => c.NumeroDeclaracao).HasColumnName("NUMERODECLARACAO");
            builder.Property(c => c.NumeroQual).HasColumnName("NUMEROQUAL");
            builder.Property(c => c.TipoRepresentacao).HasColumnName("TIPOREPRESENTACAO");
            builder.Property(d => d.DataRepresentacao).HasColumnType("date").HasColumnName("DATAREPRESENTACAO");
            builder.Property(c => c.NumOfRepresentacao).HasColumnName("NUMOFREPRESENTACAO");
            builder.Property(c => c.ExpedicaoMandado).HasColumnName("EXPEDICAOMANDADO");
            builder.Property(c => c.CumprimentoMandado).HasColumnName("CUMPRIMENTOMANDADO");
            builder.Property(c => c.UnidadePC).HasColumnName("UNIDADEPC");
            builder.Property(d => d.DataConclusao).HasColumnType("date").HasColumnName("DATACONCLUSAO");
            builder.Property(c => c.NumOfRemessa).HasColumnName("NUMOFREMESSA");
            builder.Property(c => c.Destino).HasColumnName("DESTINO");
            builder.Property(c => c.AutoridadeResponsavel).HasColumnName("AUTORIDADERESPONSAVEL");
            builder.Property(c => c.MatriculaAutoridadeResponsavel).HasColumnName("MATRICULAAUTORIDADERESPONSAVEL");
        }
    }
}
