using System;

namespace Domain.Entities
{
    public class Envolvido
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }
        public int SequencialEnvolvido { get; set; }
        public string TipoEnvolvido { get; set; }
        public string Autoria { get; set; }
        public string Turista { get; set; }
        public string NomeEnvolvido { get; set; }
        public string NomeSocial { get; set; }
        public string Vulgo { get; set; }
        public string NomeGenitora { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? IdadeExata { get; set; }
        public string IdadeAparente { get; set; }
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
        public string IntraFamiliarVitimaAutor { get; set; }
        public string InstrumentoUtilizado { get; set; }
        public string NomeInstrumentoUtilizado { get; set; }
        public string Flagrante { get; set; }
        public string MotivacaoInicial { get; set; }
        public string MotivacaoFinal { get; set; }

        //Navegação
        public EnvolvidoCriminal Criminal { get; set; }
        public EnvolvidoEndereco Endereco { get; set; }
        public EnvolvidoSaude Saude { get; set; }
    }
}
