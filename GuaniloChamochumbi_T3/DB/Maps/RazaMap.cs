using GuaniloChamochumbi_T3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.DB.Maps
{
    public class RazaMap : IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder)
        {
            builder.ToTable("Raza");
            builder.HasKey(o => o.Id);
        }
    }
}
