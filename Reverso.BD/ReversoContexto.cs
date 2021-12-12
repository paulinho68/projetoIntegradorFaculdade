using Microsoft.EntityFrameworkCore;
using ReversoBD.Entities;
using System;

namespace Reverso.BD
{
    class ReversoContexto : DbContext
    {
        static void Main(string[] args)
        {
            var reversoContexto = new ReversoContexto();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=reverso;user=root;password=", new MariaDbServerVersion("10.4.19"));
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<AreaInvestimento> AreaInvestimento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoInvestidor> TipoInvestidor { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .ToTable("usuario")
                .HasDiscriminator<string>("BaseType")
                .HasValue<PessoaFisica>("pessoaFisica")
                .HasValue<PessoaJuridica>("pessoaJuridica");

            base.OnModelCreating(builder);
        }
    }
}
