using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;
namespace ReversoBD.Seeds
{
    class TipoInvestidorSeed : IEntityTypeConfiguration<TipoInvestidor>
    {
        public void Configure(EntityTypeBuilder<TipoInvestidor> builder)
        {
            builder.HasData(new AreaInvestimento { Id = 1, Nome = "Alto Risco" });
            builder.HasData(new AreaInvestimento { Id = 2, Nome = "Médio Risco" });
            builder.HasData(new AreaInvestimento { Id = 3, Nome = "Baixo Risco" });
        }
    }
}
