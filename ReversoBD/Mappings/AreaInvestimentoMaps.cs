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
    class AreaInvestimentoMaps : IEntityTypeConfiguration<AreaInvestimento>
    {
        public void Configure(EntityTypeBuilder<AreaInvestimento> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Usuarios).WithMany(x => x.AreasInvestimentos);
            builder.ToTable("area_investimento");
        }
    }
}
