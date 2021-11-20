using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebSistemaHomicidio.ViewModels.Arquivo;
using WebSistemaHomicidio.ViewModels.Boe;
using WebSistemaHomicidio.ViewModels.Envolvido;
using WebSistemaHomicidio.ViewModels.Fato;
using WebSistemaHomicidio.ViewModels.Inquerito;

namespace WebSistemaHomicidio.ViewModels.Registro
{
    public class ExibirRegistro 
    {
        public int Id { get; set; }

        [Display(Name = "Data Registro")]
        [Required(ErrorMessage = "Informe uma {0}!")]
        public DateTime? DataRegistroBOE { get; set; }

        [Display(Name = "Nº BOE")]
        [Required(ErrorMessage = "Informe o {0}!")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "O {0} deve ter apenas 13 caracteres!")]
        public string BOE { get; set; }

        [Display(Name = "Tipo de Registro")]
        [Required(ErrorMessage = "Informe o {0}!")]
        public string TipoDeRegistro { get; set; }

        [Display(Name = "Intencionalidade")]
        [Required(ErrorMessage = "Informe a {0}!")]
        public string Intencionalidade { get; set; }

        public bool StatusRegistro { get; set; }

        public string ObservacaoRegistro { get; set; }

        public string UsuarioRegistro { get; set; }

        public ExibirFato Fato { get; set; }

        public List<NovoEnvolvido> Envolvidos { get; set; }
        public NovoInquerito Inquerito { get; set; }
        public List<NovoArquivo> Arquivos { get; set; }
        public List<NovoBoe> BoeComplementados { get; set; }
    }
}
