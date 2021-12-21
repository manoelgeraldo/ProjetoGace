using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations
{
    public class EnvolvidoConfiguration : IEntityTypeConfiguration<Envolvido>
    {
        public void Configure(EntityTypeBuilder<Envolvido> builder)
        {
            builder.ToTable("ENVOLVIDOS", "SDS_SIMIP_USU");
            builder.Property(X => X.Id).HasColumnName("ID");
            builder.Property(X => X.RegistroId).HasColumnName("RGID");
            builder.Property(i => i.SequencialEnvolvido).HasColumnName("SEQUENCIALENVOLVIDO");
            builder.Property(i => i.TipoEnvolvido).HasColumnName("TIPOENVOLVIDO");
            builder.Property(i => i.Autoria).HasColumnName("AUTORIA");
            builder.Property(i => i.Turista).HasColumnName("TURISTA");
            builder.Property(i => i.NomeEnvolvido).HasColumnName("NOMEENVOLVIDO");
            builder.Property(i => i.NomeSocial).HasColumnName("NOMESOCIAL");
            builder.Property(i => i.Vulgo).HasColumnName("VULGO");
            builder.Property(i => i.NomeGenitora).HasColumnName("NOMEGENITORA");
            builder.Property(d => d.DataNascimento).HasColumnType("date").HasColumnName("DATANASCIMENTO");
            builder.Property(i => i.IdadeExata).HasColumnName("IDADEEXATA");
            builder.Property(i => i.IdadeAparente).HasColumnName("IDADEAPARENTE");
            builder.Property(i => i.Sexo).HasColumnName("SEXO");
            builder.Property(i => i.IdentidadeGenero).HasColumnName("IDENTIDADEGENERO");
            builder.Property(i => i.OrientacaoSexual).HasColumnName("ORIENTACAOSEXUAL");
            builder.Property(i => i.DeficienciaFisica).HasColumnName("DEFICIENCIAFISICA");
            builder.Property(i => i.CorPele).HasColumnName("CORPELE");
            builder.Property(i => i.EstadoCivil).HasColumnName("ESTADOCIVIL");
            builder.Property(i => i.DepedenciaQuimica).HasColumnName("DEPEDENCIAQUIMICA");
            builder.Property(i => i.ConsumoDrogas).HasColumnName("CONSUMODROGAS");
            builder.Property(i => i.ProfissaoEnvolvildo).HasColumnName("PROFISSAOENVOLVILDO");
            builder.Property(i => i.InformacaoTrabalho).HasColumnName("INFORMACAOTRABALHO");
            builder.Property(i => i.RelacaoAutorVitima).HasColumnName("RELACAOAUTORVITIMA");
            builder.Property(i => i.IntraFamiliarVitimaAutor).HasColumnName("INTRAFAMILIARVITIMAAUTOR");
            builder.Property(i => i.InstrumentoUtilizado).HasColumnName("INSTRUMENTOUTILIZADO");
            builder.Property(i => i.NomeInstrumentoUtilizado).HasColumnName("NOMEINSTRUMENTOUTILIZADO");
            builder.Property(i => i.Flagrante).HasColumnName("FLAGRANTE");
            builder.Property(i => i.MotivacaoInicial).HasColumnName("MOTIVACAOINICIAL");
            builder.Property(i => i.MotivacaoFinal).HasColumnName("MOTIVACAOFINAL");
        }
    }
}
