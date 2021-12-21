using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SDS_SIMIP_USU");

            migrationBuilder.CreateTable(
                name: "FUNCAO",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCAO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MUNICIPIOS",
                columns: table => new
                {
                    MUNICIPIO = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    DIRETORIA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AIS = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BPM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUNICIPIOS", x => x.MUNICIPIO);
                });

            migrationBuilder.CreateTable(
                name: "REGISTROS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DATAREGISTROBOE = table.Column<DateTime>(type: "date", nullable: false),
                    BOE = table.Column<string>(type: "NVARCHAR2(13)", maxLength: 13, nullable: false),
                    TIPODEREGISTRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    INTENCIONALIDADE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATALANCAMENTO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATAATUALIZACAO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    OBSERVACAOREGISTRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STATUSREGISTRO = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    USUARIOREGISTRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EXCLUIDO = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGISTROS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    LOGIN = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NOME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SENHA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.LOGIN);
                });

            migrationBuilder.CreateTable(
                name: "ARQUIVOS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RGID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NOMEARQUIVO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPOARQUIVO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DADOSARQUIVO = table.Column<byte[]>(type: "RAW(2000)", nullable: true),
                    CRIACAOARQUIVO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARQUIVOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ARQUIVOS_REGISTROS_RGID",
                        column: x => x.RGID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "REGISTROS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOECOMPL",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RGID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    BOE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DATAREGISTRO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOECOMPL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOECOMPL_REGISTROS_RGID",
                        column: x => x.RGID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "REGISTROS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENVOLVIDOS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RGID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SEQUENCIALENVOLVIDO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TIPOENVOLVIDO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AUTORIA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TURISTA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMEENVOLVIDO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMESOCIAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    VULGO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMEGENITORA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATANASCIMENTO = table.Column<DateTime>(type: "date", nullable: true),
                    IDADEEXATA = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    IDADEAPARENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SEXO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    IDENTIDADEGENERO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ORIENTACAOSEXUAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DEFICIENCIAFISICA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CORPELE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ESTADOCIVIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DEPEDENCIAQUIMICA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CONSUMODROGAS = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PROFISSAOENVOLVILDO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    INFORMACAOTRABALHO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    RELACAOAUTORVITIMA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    INTRAFAMILIARVITIMAAUTOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    INSTRUMENTOUTILIZADO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMEINSTRUMENTOUTILIZADO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FLAGRANTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MOTIVACAOINICIAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MOTIVACAOFINAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENVOLVIDOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ENVOLVIDOS_REGISTROS_RGID",
                        column: x => x.RGID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "REGISTROS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FATOS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    RGID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATAFATO = table.Column<DateTime>(type: "date", nullable: false),
                    DIASEMANAABREVIADOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DIANUMERALFATO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    HORAFATO = table.Column<TimeSpan>(type: "INTERVAL DAY(8) TO SECOND(7)", nullable: true),
                    TURNOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NATUREZABOE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CAUSAJURIDICAFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STATUSMOTIVACAOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGIAOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MUNICIPIOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BAIRROFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LOGRADOUROFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMEROLOGRADOUROFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    COMPLEMENTOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PONTOREFERENCIAFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LOCALIDADECOMUNIDADEFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LOCALFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ZONAFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DIRETORIAFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AISFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UNIDADEPMFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UNIDADEPCFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LATITUDEFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LONGITUDEFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FONTEFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    HISTORICOFATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FATOS", x => x.RGID);
                    table.ForeignKey(
                        name: "FK_FATOS_REGISTROS_RGID",
                        column: x => x.RGID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "REGISTROS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INQUERITOS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    RGID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMEROIP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPOINSTAURACAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATAINSTAURACAO = table.Column<DateTime>(type: "date", nullable: true),
                    SITUACAOIP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMEROOUVIDA = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NUMERODECLARACAO = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    NUMEROQUAL = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TIPOREPRESENTACAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATAREPRESENTACAO = table.Column<DateTime>(type: "date", nullable: true),
                    NUMOFREPRESENTACAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EXPEDICAOMANDADO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CUMPRIMENTOMANDADO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UNIDADEPC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATACONCLUSAO = table.Column<DateTime>(type: "date", nullable: true),
                    NUMOFREMESSA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DESTINO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AUTORIDADERESPONSAVEL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MATRICULAAUTORIDADERESPONSAVEL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INQUERITOS", x => x.RGID);
                    table.ForeignKey(
                        name: "FK_INQUERITOS_REGISTROS_RGID",
                        column: x => x.RGID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "REGISTROS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FUNCAOUSUARIO",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    FUNCOESID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USUARIOSLOGIN = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCAOUSUARIO", x => new { x.FUNCOESID, x.USUARIOSLOGIN });
                    table.ForeignKey(
                        name: "FK_FUNCAO_FUNCOESID",
                        column: x => x.FUNCOESID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "FUNCAO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USUARIO_USUARIOSLOGIN",
                        column: x => x.USUARIOSLOGIN,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "USUARIO",
                        principalColumn: "LOGIN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CRIMINAL",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ENVID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ENVOLVIMENTOCRIME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITUACAOCRIMINAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PRONTUARIOSERES = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CRIMECOMETIDO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITUACAOCARCERARIA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BOEANTECEDENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPOPROCEDIMENTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRIMINAL", x => x.ENVID);
                    table.ForeignKey(
                        name: "FK_CRIMINAL_ENVOLVIDOS_ENVID",
                        column: x => x.ENVID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "ENVOLVIDOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECOS",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ENVID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    REGIAOENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MUNICIPIOENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BAIRROENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LOGRADOUROENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMEROLOGRADOUROENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    COMPLEMENTOLOGRADOUROENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PONTOREFERENCIAENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LOCALIDADECOMUNIDADEENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPORESIDENCIAENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LATITUDEENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LONGITUDEENDERECO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FONTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECOS", x => x.ENVID);
                    table.ForeignKey(
                        name: "FK_ENDERECOS_ENVOLVIDOS_ENVID",
                        column: x => x.ENVID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "ENVOLVIDOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SAUDE",
                schema: "SDS_SIMIP_USU",
                columns: table => new
                {
                    ENVID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LESAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ORGAOSOCORRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    HOSPITALSOCORRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATAOBITO = table.Column<DateTime>(type: "date", nullable: true),
                    HORAMORTE = table.Column<TimeSpan>(type: "INTERVAL DAY(8) TO SECOND(7)", nullable: true),
                    LOCALMORTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UNIDADEHOSPITALAR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NIC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGISTROIML = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    IML = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMERODECLARACAOOBITO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    GDL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITUACAOVITIMAACIDENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TRANSPORTEVITIMA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TRANSPORTEAUTOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAUDE", x => x.ENVID);
                    table.ForeignKey(
                        name: "FK_SAUDE_ENVOLVIDOS_ENVID",
                        column: x => x.ENVID,
                        principalSchema: "SDS_SIMIP_USU",
                        principalTable: "ENVOLVIDOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARQUIVOS_RGID",
                schema: "SDS_SIMIP_USU",
                table: "ARQUIVOS",
                column: "RGID");

            migrationBuilder.CreateIndex(
                name: "IX_BOECOMPL_RGID",
                schema: "SDS_SIMIP_USU",
                table: "BOECOMPL",
                column: "RGID");

            migrationBuilder.CreateIndex(
                name: "IX_ENVOLVIDOS_RGID",
                schema: "SDS_SIMIP_USU",
                table: "ENVOLVIDOS",
                column: "RGID");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCAOUSUARIO_USUARIOSLOGIN",
                schema: "SDS_SIMIP_USU",
                table: "FUNCAOUSUARIO",
                column: "USUARIOSLOGIN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARQUIVOS",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "BOECOMPL",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "CRIMINAL",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "ENDERECOS",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "FATOS",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "FUNCAOUSUARIO",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "INQUERITOS",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "MUNICIPIOS");

            migrationBuilder.DropTable(
                name: "SAUDE",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "FUNCAO",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "USUARIO",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "ENVOLVIDOS",
                schema: "SDS_SIMIP_USU");

            migrationBuilder.DropTable(
                name: "REGISTROS",
                schema: "SDS_SIMIP_USU");
        }
    }
}
