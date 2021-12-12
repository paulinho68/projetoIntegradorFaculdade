using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;
using System;

namespace ReversoBD.Mappings
{
    class AreaInvestimentoUsuarioMaps : IEntityTypeConfiguration<AreaInvestimentoUsuario>
    {
        public void Configure(EntityTypeBuilder<AreaInvestimentoUsuario> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.IdUsuario).IsRequired();
            builder.Property(x => x.IdAreaInvestimento).IsRequired();
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario).WithMany(x => x.AreasInvestimentosUsuarios).HasForeignKey(x => x.IdUsuario).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.AreaInvestimento).WithMany(x => x.AreasInvestimentosUsuarios).HasForeignKey(x => x.IdAreaInvestimento).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("area_investimento_usuario");
        }
    }
}
