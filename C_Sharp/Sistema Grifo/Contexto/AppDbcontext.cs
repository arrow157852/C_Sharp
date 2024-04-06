using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Sistema_Grifo.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
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
        public DbSet<Geralresult> GeralResults { get; set; }

        public DbSet<TabelaTemporaria> tabelaTemporarias { get; set; }
        public DbSet<Configuracoesapp> Configuracoesapps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=NBCOMERCIAL;Initial Catalog=sistema;Integrated Security=True", options =>
            options.EnableRetryOnFailure());

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaoDeObra>().HasKey(c => c.cargosID);

            modelBuilder.Entity<Diversos>().HasKey(c => c.CustoID);
            modelBuilder.Entity<TabelaTemporaria>().HasKey(c => c.temporarioID);
            modelBuilder.Entity<Geralresult>().HasKey(c => c.id);
            

            modelBuilder.Entity<Material>().ToTable("planilha");
            modelBuilder.Entity<MaoDeObra>().ToTable("cargos");
            modelBuilder.Entity<Diversos>().ToTable("custosdiversos");
            modelBuilder.Entity<Geralresult>().ToTable("geralresult");
            modelBuilder.Entity<Configuracoesapp>().ToTable("configuracoesapp");


            modelBuilder.Entity<TabelaTemporaria>().ToTable("tabelatemporaria");
        }
        


    }
}
