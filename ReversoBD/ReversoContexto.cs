using Microsoft.EntityFrameworkCore;
using ReversoBD.Entities;
using ReversoBD.Mappings;
using ReversoBD.Seeds;
using ReversoBD.Tools;

namespace ReversoBD
{
    public class ReversoContexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.ConnectionString, new MariaDbServerVersion(Config.MariaDbVersion));
            //optionsBuilder.UseMySql("server=localhost;database=reverso;user=root;password=", new MariaDbServerVersion("10.4.19"));
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
            //Migrations
            builder.ApplyConfiguration(new UsuarioMaps());
            builder.ApplyConfiguration(new TelefoneMaps());
            builder.ApplyConfiguration(new PessoaFisicaMaps());
            builder.ApplyConfiguration(new PessoaJuridicaMaps());
            builder.ApplyConfiguration(new TipoInvestidorMaps());
            builder.ApplyConfiguration(new EnderecoMaps());
            builder.ApplyConfiguration(new AreaInvestimentoMaps());

            //Seeds
            builder.ApplyConfiguration(new AreaInvestimentoSeed());
            builder.ApplyConfiguration(new TipoInvestidorSeed());
        }

    }
}
