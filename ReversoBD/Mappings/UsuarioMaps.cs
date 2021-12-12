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
    public class UsuarioMaps : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(180);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(255);
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PessoaFisica).WithOne(x => x.Usuario).HasForeignKey<PessoaFisica>(x => x.IdUsuario).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.PessoaJuridica).WithOne(x => x.Usuario).HasForeignKey<PessoaJuridica>(x => x.IdUsuario).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Endereco).WithOne(x => x.Usuario).HasForeignKey<Endereco>(x => x.IdUsuario).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("usuario");
        }
    }
}
