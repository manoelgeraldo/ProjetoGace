using System;
using System.ComponentModel.DataAnnotations;

namespace Infra.CrossCutting.ViewModels.Envolvido
{
    public class NovoEnvolvido
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }

        /// <summary>
        /// Informe o sequencial do envolvido.
        /// </summary>
        /// <example>1</example>
        public int SequencialEnvolvido { get; set; }

        /// <summary>
        /// Tipo de envolvimento
        /// </summary>
        /// <example>VITIMA</example>.
        public string TipoEnvolvido { get; set; }

        /// <summary>
        /// Qualificação do envolvido.
        /// </summary>
        /// <example>CONHECIDA</example>.
        public string Autoria { get; set; }

        /// <summary>
        /// Informe se é turista ou não.
        /// </summary>
        /// <example>NAO</example>.
        public string Turista { get; set; }

        /// <summary>
        /// Nome do envolvido.
        /// </summary>
        /// <example>FERNADINHO BEIRA MAR</example>.
        public string NomeEnvolvido { get; set; }

        /// <summary>
        /// Informe o nome social se houver.
        /// </summary>
        public string NomeSocial { get; set; }

        /// <summary>
        /// Informe o vulgo do envolvido.
        /// </summary>
        public string Vulgo { get; set; }

        /// <summary>
        /// Nome da genitora.
        /// </summary>
        /// <example>DONA MARIA</example>.
        public string NomeGenitora { get; set; }

        /// <summary>
        /// Data de Nascimento do envolvido.
        /// </summary>
        /// <example>01/01/2021</example>.
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// Informe a idade aparente.
        /// </summary>
        /// <example>21</example>.
        public string IdadeAparente { get; set; }

        /// <summary>
        /// Informe a idade aparente.
        /// </summary>
        /// <example>21</example>.
        public int? IdadeExata { get; set; }
        public string Sexo { get; set; }
        public string IdentidadeGenero { get; set; }
        public string OrientacaoSexual { get; set; }
        public string DeficienciaFisica { get; set; }
        public string CorPele { get; set; }
        public string EstadoCivil { get; set; }
        public string DepedenciaQuimica { get; set; }
        public string ConsumoDrogas { get; set; }
        public string ProfissaoEnvolvildo { get; set; }
        public string InformacaoTrabalho { get; set; }
        public string RelacaoAutorVitima { get; set; }
        public string RelacaoIntraFamiliarVitimaAutor { get; set; }
        public string InstrumentoUtilizado { get; set; }
        public string NomeInstrumentoUtilizado { get; set; }
        public string Flagrante { get; set; }
        public string MotivacaoInicial { get; set; }
        public string MotivacaoFinal { get; set; }

        //Navegação
        public NovoCriminal Criminal { get; set; }
        public NovoEndereco Endereco { get; set; }
        public NovoSaude Saude { get; set; }
    }
}
