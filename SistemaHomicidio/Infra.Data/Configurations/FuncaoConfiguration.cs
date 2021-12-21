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
    public class FuncaoConfiguration : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.ToTable("FUNCOES","SDS_SIMIP_USU");
            builder.HasKey(c => c.Id);
            builder.Property(X => X.Id).HasColumnName("ID");
            builder.Property(X => X.Descricao).HasColumnName("DESCRICAO");
        }
    }
}
