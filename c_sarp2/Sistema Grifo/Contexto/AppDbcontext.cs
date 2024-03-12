using Microsoft.EntityFrameworkCore;
using Sistema_Grifo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Grifo.contexto
{
    internal class AppDbcontext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaoDeObra> MaoDeObras { get; set; }
        public DbSet<Diversos> Diversoss { get; set; }
        public DbSet<TabelaTemporaria> tabelaTemporarias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=grifo;Uid=root;Pwd=1578");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaoDeObra>().HasKey(c => c.cargosID);

            modelBuilder.Entity<Diversos>().HasKey(c => c.CustoID);
            modelBuilder.Entity<TabelaTemporaria>().HasKey(c => c.temporarioID);

            modelBuilder.Entity<Material>().ToTable("planilha");
            modelBuilder.Entity<MaoDeObra>().ToTable("cargos");
            modelBuilder.Entity<Diversos>().ToTable("custosdiversos");
            modelBuilder.Entity<TabelaTemporaria>().ToTable("descricao");
        }


    }
}
