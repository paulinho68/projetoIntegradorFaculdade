using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversoBD.Mappings
{
    class TipoInvestidorMaps : IEntityTypeConfiguration<TipoInvestidor>
    {
        public void Configure(EntityTypeBuilder<TipoInvestidor> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.HasMany(x => x.PessoasFisicas).WithOne(x => x.TipoInvestidor).HasForeignKey(x => x.idTipoInvestidor).OnDelete(DeleteBehavior.Restrict); ;
            builder.ToTable("tipo_investidor");
        }
    }
}
