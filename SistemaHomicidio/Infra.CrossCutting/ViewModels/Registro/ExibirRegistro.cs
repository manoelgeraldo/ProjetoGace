using Infra.CrossCutting.ViewModels.Arquivo;
using Infra.CrossCutting.ViewModels.Boe;
using Infra.CrossCutting.ViewModels.Envolvido;
using Infra.CrossCutting.ViewModels.Fato;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infra.CrossCutting.ViewModels
{
    public class ExibirRegistro
    {
        public int Id { get; set; }
        /// <summary>
        /// Data Registro do Boletim eletrônico.
        /// </summary>
        /// <example>01/01/2021</example>.
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DataRegistroBOE { get; set; }

        /// <summary>
        /// Número do Boletim eletrônico.
        /// </summary>
        /// <example>21E0000000001</example>
        public string BOE { get; set; }

        /// <summary>
        /// Informe o Tipo do Registro.
        /// </summary>
        /// <example>TENTATIVA</example>
        public string TipoDeRegistro { get; set; }

        /// <summary>
        /// Informe a Intencionalidade.
        /// </summary>
        /// <example>CULPOSO</example>
        public string Intencionalidade { get; set; }
        /// <summary>
        /// Informe o status.
        /// </summary>
        /// <example>CONSISTIDO</example>
        public bool StatusRegistro { get; set; }

        /// <summary>
        /// Espaço reservado para anotações de observações sobre o registro.
        /// </summary>
        /// /// <example>TESTANDO API</example>
        public string ObservacaoRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public ExibirFato Fato { get; set; }
        public List<NovoEnvolvido> Envolvidos { get; set; }
        public NovoInquerito Inquerito { get; set; }
        public List<NovoArquivo> Arquivos { get; set; }
        public List<NovoBoe> BoeComplementados { get; set; }
    }
}
