using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.ViewModels.Boe
{
    public class NovoBoe
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }

        /// <summary>
        /// Número do Boletim eletrônico complementado.
        /// </summary>
        /// <example>21E0000000000</example>
        public string Boe { get; set; }

        /// <summary>
        /// Data Registro do Boletim eletrônico Complementado.
        /// </summary>
        /// <example>11/05/2021</example>
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DataRegistro { get; set; }
    }
}
