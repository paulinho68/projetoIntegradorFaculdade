using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;

namespace ReversoBD.Mappings
{
    public class TelefoneMaps : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.IdUsuario).IsRequired();
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(20);
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario).WithMany(x => x.Telefones).HasForeignKey(x => x.IdUsuario).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("telefone");
        }
    }
}
