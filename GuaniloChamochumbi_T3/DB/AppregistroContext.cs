using GuaniloChamochumbi_T3.DB.Maps;
using GuaniloChamochumbi_T3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.DB
{
    public class AppregistroContext : DbContext
    {
        public DbSet<registro> Registros { get; set; }
        public DbSet<Sexo> sexos { get; set; }
        public DbSet<Raza> razas { get; set; }
        public DbSet<Especie> especies { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public AppregistroContext(DbContextOptions<AppregistroContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.ApplyConfiguration(new registroMap());
            modelBuilder.ApplyConfiguration(new SexoMap());
            modelBuilder.ApplyConfiguration(new RazaMap());
            modelBuilder.ApplyConfiguration(new EspecieMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
