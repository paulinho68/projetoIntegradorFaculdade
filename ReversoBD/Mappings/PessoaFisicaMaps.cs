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
    public class PessoaFisicaMaps : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.IdUsuario).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DataNasc).IsRequired();
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(20);
            builder.HasKey(x => x.Id);
            builder.ToTable("pessoa_fisica");
        }
    }
}
