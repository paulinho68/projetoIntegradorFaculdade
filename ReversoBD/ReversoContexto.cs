using Microsoft.EntityFrameworkCore;
using ReversoBD.Entities;
using ReversoBD.Mappings;
using ReversoBD.Tools;
using System;

namespace ReversoBD
{
    public class ReversoContexto : DbContext
    {
        //public ReversoContexto()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(Config.ConnectionString, new MariaDbServerVersion(Config.MariaDbVersion));
            optionsBuilder.UseMySql("server=localhost;database=reverso;user=root;password=", new MariaDbServerVersion("10.4.19"));
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        //public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        //public DbSet<AreaInvestimento> AreasInvestimentos { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        //public DbSet<TipoInvestidor> TipoInvestidores { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioMaps());
            builder.ApplyConfiguration(new TelefoneMaps());
            builder.ApplyConfiguration(new PessoaFisicaMaps());
        }

    }
}
