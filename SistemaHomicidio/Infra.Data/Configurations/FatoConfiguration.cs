using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class FatoConfiguration : IEntityTypeConfiguration<Fato>
    {
        public void Configure(EntityTypeBuilder<Fato> builder)
        {
            builder.ToTable("FATOS", "SDS_SIMIP_USU");
            builder.HasKey(c => c.RegistroId);
            builder.Property(c => c.RegistroId).HasColumnName("RGID");
            builder.Property(d => d.DataFato).HasColumnType("date").HasColumnName("DATAFATO");
            builder.Property(c => c.DiaSemanaAbreviadoFato).HasColumnName("DIASEMANAABREVIADOFATO");
            builder.Property(c => c.DiaNumeralFato).HasColumnName("DIANUMERALFATO");
            builder.Property(c => c.HoraFato).HasColumnName("HORAFATO");
            builder.Property(c => c.TurnoFato).HasColumnName("TURNOFATO");
            builder.Property(c => c.NaturezaBoe).HasColumnName("NATUREZABOE");
            builder.Property(c => c.CausaJuridicaFato).HasColumnName("CAUSAJURIDICAFATO");
            builder.Property(c => c.StatusMotivacaoFato).HasColumnName("STATUSMOTIVACAOFATO");
            builder.Property(c => c.RegiaoFato).HasColumnName("REGIAOFATO");
            builder.Property(c => c.MunicipioFato).HasColumnName("MUNICIPIOFATO");
            builder.Property(c => c.BairroFato).HasColumnName("BAIRROFATO");
            builder.Property(c => c.LogradouroFato).HasColumnName("LOGRADOUROFATO");
            builder.Property(c => c.NumeroLogradouroFato).HasColumnName("NUMEROLOGRADOUROFATO");
            builder.Property(c => c.ComplementoFato).HasColumnName("COMPLEMENTOFATO");
            builder.Property(c => c.PontoReferenciaFato).HasColumnName("PONTOREFERENCIAFATO");
            builder.Property(c => c.LocalidadeComunidadeFato).HasColumnName("LOCALIDADECOMUNIDADEFATO");
            builder.Property(c => c.LocalFato).HasColumnName("LOCALFATO");
            builder.Property(c => c.ZonaFato).HasColumnName("ZONAFATO");
            builder.Property(c => c.DiretoriaFato).HasColumnName("DIRETORIAFATO");
            builder.Property(c => c.AisFato).HasColumnName("AISFATO");
            builder.Property(c => c.UnidadePMFato).HasColumnName("UNIDADEPMFATO");
            builder.Property(c => c.UnidadePCFato).HasColumnName("UNIDADEPCFATO");
            builder.Property(c => c.LatitudeFato).HasColumnName("LATITUDEFATO");
            builder.Property(c => c.LongitudeFato).HasColumnName("LONGITUDEFATO");
            builder.Property(c => c.FonteFato).HasColumnName("FONTEFATO");
            builder.Property(c => c.HistoricoFato).HasColumnName("HISTORICOFATO");
        }
    }
}
