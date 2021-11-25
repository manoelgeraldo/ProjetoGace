using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio_Diretoria_AIS_BPMs",
                columns: table => new
                {
                    Municipio = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Diretoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio_Diretoria_AIS_BPMs", x => x.Municipio);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRegistroBOE = table.Column<DateTime>(type: "date", nullable: false),
                    BOE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    TipoDeRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intencionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ObservacaoRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusRegistro = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Login);
                });

            migrationBuilder.CreateTable(
                name: "Arquivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    NomeArquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoArquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DadosArquivo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CriacaoArquivo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arquivos_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoeComplementados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    Boe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoeComplementados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoeComplementados_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Envolvidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    SequencialEnvolvido = table.Column<int>(type: "int", nullable: false),
                    TipoEnvolvido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEnvolvido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vulgo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeGenitora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: true),
                    IdadeExata = table.Column<int>(type: "int", nullable: true),
                    IdadeAparente = table.Column<int>(type: "int", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentidadeGenero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrientacaoSexual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeficienciaFisica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorPele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepedenciaQuimica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumoDrogas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfissaoEnvolvildo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformacaoTrabalho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelacaoAutorVitima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelacaoIntraFamiliarVitimaAutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentoUtilizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeInstrumentoUtilizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flagrante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivacaoInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotivacaoFinal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envolvidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envolvidos_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fatos",
                columns: table => new
                {
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    DataFato = table.Column<DateTime>(type: "date", nullable: false),
                    DiaSemanaAbreviadoFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaNumeralFato = table.Column<int>(type: "int", nullable: false),
                    HoraFato = table.Column<TimeSpan>(type: "time", nullable: true),
                    TurnoFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaturezaBoe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CausaJuridicaFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusMotivacaoFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegiaoFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BairroFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogradouroFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroLogradouroFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplementoFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontoReferenciaFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadeComunidadeFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZonaFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiretoriaFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AisFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadePMFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadePCFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatitudeFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongitudeFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FonteFato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoricoFato = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatos", x => x.RegistroId);
                    table.ForeignKey(
                        name: "FK_Fatos_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inqueritos",
                columns: table => new
                {
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    NumeroIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoInstauracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInstaraucao = table.Column<DateTime>(type: "date", nullable: true),
                    MotivacaoIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOuvida = table.Column<int>(type: "int", nullable: true),
                    NumeroDeclaracao = table.Column<int>(type: "int", nullable: true),
                    NumeroQual = table.Column<int>(type: "int", nullable: true),
                    TipoRepresentacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRepresentacao = table.Column<DateTime>(type: "date", nullable: true),
                    NumOfRepresentacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpedicaoMandado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CumprimentoMandado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadePC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataConclusao = table.Column<DateTime>(type: "date", nullable: true),
                    NumOfRemessa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoridadeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatriculaAutoridadeResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inqueritos", x => x.RegistroId);
                    table.ForeignKey(
                        name: "FK_Inqueritos_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuncaoUsuario",
                columns: table => new
                {
                    FuncoesId = table.Column<int>(type: "int", nullable: false),
                    UsuariosLogin = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncaoUsuario", x => new { x.FuncoesId, x.UsuariosLogin });
                    table.ForeignKey(
                        name: "FK_FuncaoUsuario_Funcoes_FuncoesId",
                        column: x => x.FuncoesId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuncaoUsuario_Usuarios_UsuariosLogin",
                        column: x => x.UsuariosLogin,
                        principalTable: "Usuarios",
                        principalColumn: "Login",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criminal",
                columns: table => new
                {
                    EnvolvidoId = table.Column<int>(type: "int", nullable: false),
                    EnvolvimentoCrime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoCriminal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProntuarioSeres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrimeCometido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoCarceraria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoeAntecedente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoProcedimento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criminal", x => x.EnvolvidoId);
                    table.ForeignKey(
                        name: "FK_Criminal_Envolvidos_EnvolvidoId",
                        column: x => x.EnvolvidoId,
                        principalTable: "Envolvidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnvolvidoId = table.Column<int>(type: "int", nullable: false),
                    RegiaoEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BairroEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogradouroEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroLogradouroEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplementoLogradouroEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontoReferenciaEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadeComunidadeEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoResidenciaEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatitudeEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongitudeEndereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fonte = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnvolvidoId);
                    table.ForeignKey(
                        name: "FK_Enderecos_Envolvidos_EnvolvidoId",
                        column: x => x.EnvolvidoId,
                        principalTable: "Envolvidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saude",
                columns: table => new
                {
                    EnvolvidoId = table.Column<int>(type: "int", nullable: false),
                    Lesao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgaoSocorro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalSocorro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataObito = table.Column<DateTime>(type: "date", nullable: true),
                    HoraMorte = table.Column<TimeSpan>(type: "time", nullable: true),
                    LocalMorte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeHospitalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroIML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDeclaracaoObito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GDL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoVitimaAcidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransporteVitima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransporteAutor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saude", x => x.EnvolvidoId);
                    table.ForeignKey(
                        name: "FK_Saude_Envolvidos_EnvolvidoId",
                        column: x => x.EnvolvidoId,
                        principalTable: "Envolvidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arquivos_RegistroId",
                table: "Arquivos",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_BoeComplementados_RegistroId",
                table: "BoeComplementados",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Envolvidos_RegistroId",
                table: "Envolvidos",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncaoUsuario_UsuariosLogin",
                table: "FuncaoUsuario",
                column: "UsuariosLogin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivos");

            migrationBuilder.DropTable(
                name: "BoeComplementados");

            migrationBuilder.DropTable(
                name: "Criminal");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Fatos");

            migrationBuilder.DropTable(
                name: "FuncaoUsuario");

            migrationBuilder.DropTable(
                name: "Inqueritos");

            migrationBuilder.DropTable(
                name: "Municipio_Diretoria_AIS_BPMs");

            migrationBuilder.DropTable(
                name: "Saude");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Envolvidos");

            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
