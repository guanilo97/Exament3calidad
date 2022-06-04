using GuaniloChamochumbi_T3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.DB.Maps
{
    public class registroMap : IEntityTypeConfiguration<registro>
    {
        public void Configure(EntityTypeBuilder<registro> builder)
        {
            builder.ToTable("registro");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.sexo).WithMany().HasForeignKey(o => o.Id_sexo);
            builder.HasOne(o => o.raza).WithMany().HasForeignKey(o => o.Id_raza);
            builder.HasOne(o => o.especie).WithMany().HasForeignKey(o => o.Id_especie);
        }
    }
}
