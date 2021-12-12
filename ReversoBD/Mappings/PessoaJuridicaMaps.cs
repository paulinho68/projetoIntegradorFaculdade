using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReversoBD.Entities;
namespace ReversoBD.Mappings
{
    public class PessoaJuridicaMaps : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseMySqlIdentityColumn();
            builder.Property(x => x.IdUsuario).IsRequired();
            builder.Property(x => x.NomeFantasia).IsRequired().HasMaxLength(255);
            builder.Property(x => x.RazaoSocial).IsRequired();
            builder.Property(x => x.CNPJ).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Analisado);
            builder.HasKey(x => x.Id);
            builder.ToTable("pessoa_juridica");
        }
    }
}
