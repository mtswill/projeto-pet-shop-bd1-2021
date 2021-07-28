using Microsoft.EntityFrameworkCore;
using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Data
{
    public class PetShopContext : DbContext
    {
        protected PetShopContext() { }

        public PetShopContext(DbContextOptions<PetShopContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region PK

            modelBuilder.Entity<Funcionario>().HasKey(f => f.Id);
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

            #endregion PK

            #region Relacionamentos

            modelBuilder.Entity<Cliente>().HasOne(c => c.Pessoa);
            modelBuilder.Entity<Funcionario>().HasOne(f => f.Pessoa);

            modelBuilder.Entity<Animal>().HasOne(a => a.Raca);
            modelBuilder.Entity<Animal>().HasOne(a => a.Cliente);
            modelBuilder.Entity<Raca>().HasOne(r => r.TipoAnimal);

            modelBuilder.Entity<Atendimento>().HasOne(a => a.Animal);
            modelBuilder.Entity<Atendimento>().HasOne(a => a.Funcionario);

            #endregion Relacionamentos
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<TipoAnimal> TipoAnimal { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Servico> Servico { get; set; }
    }
}
