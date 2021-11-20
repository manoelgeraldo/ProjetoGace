using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BoeComplementado
    {
        public int? Id { get; set; }
        public int RegistroId { get; set; }
        public string Boe { get; set; }
        public DateTime? DataRegistro { get; set; }
    }
}
