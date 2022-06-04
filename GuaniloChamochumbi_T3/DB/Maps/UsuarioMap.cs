using GuaniloChamochumbi_T3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.DB.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o => o.Id);
        }
    }
}
