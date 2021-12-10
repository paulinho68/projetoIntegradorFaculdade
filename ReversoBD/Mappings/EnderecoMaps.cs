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
    class EnderecoMaps : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.IdUsuario).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.Complemento).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CEP).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Pais).IsRequired().HasMaxLength(255);
            builder.HasKey(x => x.Id);
            builder.ToTable("endereco");
        }
    }
}
