using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configurations
{
    public class FatoConfiguration : IEntityTypeConfiguration<Fato>
    {
        public void Configure(EntityTypeBuilder<Fato> builder)
        {
            builder.HasKey(c => c.RegistroId);
            builder.Property(d => d.DataFato).HasColumnType("date");
        }
    }
}
