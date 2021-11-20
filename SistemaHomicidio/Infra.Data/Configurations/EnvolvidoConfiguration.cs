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
    public class EnvolvidoConfiguration : IEntityTypeConfiguration<Envolvido>
    {
        public void Configure(EntityTypeBuilder<Envolvido> builder)
        {
            builder.Property(d => d.DataNascimento).HasColumnType("date");
        }
    }
}
