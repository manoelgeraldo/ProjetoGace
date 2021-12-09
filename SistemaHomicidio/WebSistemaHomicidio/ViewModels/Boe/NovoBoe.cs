using System;
using System.ComponentModel.DataAnnotations;

namespace WebSistemaHomicidio.ViewModels.Boe
{
    public class NovoBoe
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }

        [Display(Name = "Nº BOE")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "O {0} deve ter apenas 13 caracteres!")]
        [Required(ErrorMessage = "Informe o {0}!")]
        public string Boe { get; set; }

        [DataType(DataType.Date), Display(Name = "Data Registro")]
        [Required(ErrorMessage = "Informe a {0}!")]
        public DateTime? DataRegistro { get; set; }
    }
}
