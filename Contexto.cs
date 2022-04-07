using EstoqueComBD.Model.Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueComBD
{
    class Contexto: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=estoque;Uid=root;Pwd=;";
            object p = optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new System.Version(5, 7, 31)));
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente{ get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>().HasData(new Cliente(1, "Pedro Silva", "pedro@gmail.com"));
            modelBuilder.Entity<Cliente>().HasData(new Cliente(2, "Maria Souza", "maria@gmail.com"));
        }

    }
     

        
        
}
