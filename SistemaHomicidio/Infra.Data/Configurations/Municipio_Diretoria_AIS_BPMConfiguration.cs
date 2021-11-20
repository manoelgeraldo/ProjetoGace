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
    public class Municipio_Diretoria_AIS_BPMConfiguration : IEntityTypeConfiguration<Municipio_Diretoria_AIS_BPM>
    {
        public void Configure(EntityTypeBuilder<Municipio_Diretoria_AIS_BPM> builder)
        {
            builder.HasKey(k => k.Municipio);
        }
    }
}
