﻿// <auto-generated />
using System;
using Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Data.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20211208233813_AddCampoExcluido")]
    partial class AddCampoExcluido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Arquivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CriacaoArquivo")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("DadosArquivo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeArquivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("TipoArquivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.ToTable("Arquivos");
                });

            modelBuilder.Entity("Domain.Entities.BoeComplementado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Boe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataRegistro")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.ToTable("BoeComplementados");
                });

            modelBuilder.Entity("Domain.Entities.Envolvido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsumoDrogas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorPele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("DeficienciaFisica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepedenciaQuimica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flagrante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdadeAparente")
                        .HasColumnType("int");

                    b.Property<int?>("IdadeExata")
                        .HasColumnType("int");

                    b.Property<string>("IdentidadeGenero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformacaoTrabalho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentoUtilizado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivacaoFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivacaoInicial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEnvolvido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeGenitora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeInstrumentoUtilizado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrientacaoSexual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfissaoEnvolvildo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("RelacaoAutorVitima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntraFamiliarVitimaAutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SequencialEnvolvido")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoEnvolvido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vulgo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistroId");

                    b.ToTable("Envolvidos");
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoCriminal", b =>
                {
                    b.Property<int>("EnvolvidoId")
                        .HasColumnType("int");

                    b.Property<string>("BoeAntecedente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrimeCometido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvolvimentoCrime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProntuarioSeres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoCarceraria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoCriminal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoProcedimento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvolvidoId");

                    b.ToTable("Criminal");
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoEndereco", b =>
                {
                    b.Property<int>("EnvolvidoId")
                        .HasColumnType("int");

                    b.Property<string>("BairroEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplementoLogradouroEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fonte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatitudeEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalidadeComunidadeEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogradouroEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongitudeEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MunicipioEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroLogradouroEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PontoReferenciaEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegiaoEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoResidenciaEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvolvidoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoSaude", b =>
                {
                    b.Property<int>("EnvolvidoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataObito")
                        .HasColumnType("date");

                    b.Property<string>("GDL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("HoraMorte")
                        .HasColumnType("time");

                    b.Property<string>("HospitalSocorro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lesao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalMorte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeclaracaoObito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgaoSocorro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroIML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoVitimaAcidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransporteAutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransporteVitima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadeHospitalar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvolvidoId");

                    b.ToTable("Saude");
                });

            modelBuilder.Entity("Domain.Entities.Fato", b =>
                {
                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("AisFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BairroFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CausaJuridicaFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplementoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFato")
                        .HasColumnType("date");

                    b.Property<int>("DiaNumeralFato")
                        .HasColumnType("int");

                    b.Property<string>("DiaSemanaAbreviadoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiretoriaFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FonteFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistoricoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("HoraFato")
                        .HasColumnType("time");

                    b.Property<string>("LatitudeFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalidadeComunidadeFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogradouroFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongitudeFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MunicipioFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NaturezaBoe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroLogradouroFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PontoReferenciaFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegiaoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusMotivacaoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurnoFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadePCFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadePMFato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonaFato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistroId");

                    b.ToTable("Fatos");
                });

            modelBuilder.Entity("Domain.Entities.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcoes");
                });

            modelBuilder.Entity("Domain.Entities.Inquerito", b =>
                {
                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.Property<string>("AutoridadeResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CumprimentoMandado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DataInstaraucao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DataRepresentacao")
                        .HasColumnType("date");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpedicaoMandado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatriculaAutoridadeResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumOfRemessa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumOfRepresentacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroDeclaracao")
                        .HasColumnType("int");

                    b.Property<string>("NumeroIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumeroOuvida")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroQual")
                        .HasColumnType("int");

                    b.Property<string>("SituacaoIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoInstauracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoRepresentacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadePC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistroId");

                    b.ToTable("Inqueritos");
                });

            modelBuilder.Entity("Domain.Entities.Municipio_Diretoria_AIS_BPM", b =>
                {
                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AIS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diretoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Municipio");

                    b.ToTable("Municipio_Diretoria_AIS_BPMs");
                });

            modelBuilder.Entity("Domain.Entities.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BOE")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRegistroBOE")
                        .HasColumnType("date");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<string>("Intencionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObservacaoRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatusRegistro")
                        .HasColumnType("bit");

                    b.Property<string>("TipoDeRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FuncaoUsuario", b =>
                {
                    b.Property<int>("FuncoesId")
                        .HasColumnType("int");

                    b.Property<string>("UsuariosLogin")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FuncoesId", "UsuariosLogin");

                    b.HasIndex("UsuariosLogin");

                    b.ToTable("FuncaoUsuario");
                });

            modelBuilder.Entity("Domain.Entities.Arquivo", b =>
                {
                    b.HasOne("Domain.Entities.Registro", null)
                        .WithMany("Arquivos")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.BoeComplementado", b =>
                {
                    b.HasOne("Domain.Entities.Registro", null)
                        .WithMany("BoeComplementados")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Envolvido", b =>
                {
                    b.HasOne("Domain.Entities.Registro", null)
                        .WithMany("Envolvidos")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoCriminal", b =>
                {
                    b.HasOne("Domain.Entities.Envolvido", null)
                        .WithOne("Criminal")
                        .HasForeignKey("Domain.Entities.EnvolvidoCriminal", "EnvolvidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoEndereco", b =>
                {
                    b.HasOne("Domain.Entities.Envolvido", null)
                        .WithOne("Endereco")
                        .HasForeignKey("Domain.Entities.EnvolvidoEndereco", "EnvolvidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.EnvolvidoSaude", b =>
                {
                    b.HasOne("Domain.Entities.Envolvido", null)
                        .WithOne("Saude")
                        .HasForeignKey("Domain.Entities.EnvolvidoSaude", "EnvolvidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Fato", b =>
                {
                    b.HasOne("Domain.Entities.Registro", null)
                        .WithOne("Fato")
                        .HasForeignKey("Domain.Entities.Fato", "RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Inquerito", b =>
                {
                    b.HasOne("Domain.Entities.Registro", null)
                        .WithOne("Inquerito")
                        .HasForeignKey("Domain.Entities.Inquerito", "RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FuncaoUsuario", b =>
                {
                    b.HasOne("Domain.Entities.Funcao", null)
                        .WithMany()
                        .HasForeignKey("FuncoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosLogin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Envolvido", b =>
                {
                    b.Navigation("Criminal");

                    b.Navigation("Endereco");

                    b.Navigation("Saude");
                });

            modelBuilder.Entity("Domain.Entities.Registro", b =>
                {
                    b.Navigation("Arquivos");

                    b.Navigation("BoeComplementados");

                    b.Navigation("Envolvidos");

                    b.Navigation("Fato");

                    b.Navigation("Inquerito");
                });
#pragma warning restore 612, 618
        }
    }
}
