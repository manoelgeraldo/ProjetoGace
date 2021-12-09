using System;

namespace Domain.Entities
{
    public class BoeComplementado
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }
        public string Boe { get; set; }
        public DateTime? DataRegistro { get; set; }
    }
}
