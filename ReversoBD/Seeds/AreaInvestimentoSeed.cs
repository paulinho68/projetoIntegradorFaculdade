using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;

namespace ReversoBD.Seeds
{
    class AreaInvestimentoSeed : IEntityTypeConfiguration<AreaInvestimento>
    {
        public void Configure(EntityTypeBuilder<AreaInvestimento> builder)
        {
            builder.HasData(new AreaInvestimento { Id = 1, Nome = "Criptomoedas" });
            builder.HasData(new AreaInvestimento { Id = 2, Nome = "Tesouro Direto" });
            builder.HasData(new AreaInvestimento { Id = 3, Nome = "Fundos Imobiliários" });
            builder.HasData(new AreaInvestimento { Id = 4, Nome = "Renda Fixa" });
            builder.HasData(new AreaInvestimento { Id = 5, Nome = "CBDs" });
            builder.HasData(new AreaInvestimento { Id = 6, Nome = "Ações" });
        }
    }
}
