﻿using System;

namespace WebSistemaHomicidio.ViewModels.Envolvido
{
    public class NovoEnvolvido
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
        public int? IdadeAparente { get; set; }
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

        //Navegação
        public NovoCriminal Criminal { get; set; }
        public NovoEndereco Endereco { get; set; }
        public NovoSaude Saude { get; set; }
    }
}
