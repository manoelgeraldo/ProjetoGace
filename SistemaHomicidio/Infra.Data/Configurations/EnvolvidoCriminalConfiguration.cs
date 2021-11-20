﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configurations
{ 
    public class EnvolvidoCriminalConfiguration : IEntityTypeConfiguration<EnvolvidoCriminal>
    {
        public void Configure(EntityTypeBuilder<EnvolvidoCriminal> builder)
        {
            builder.HasKey(c => c.EnvolvidoId);
        }
    }
    
}
