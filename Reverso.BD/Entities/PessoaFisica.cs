using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("pessoaFisica")]
    public class PessoaFisica : Usuario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNasc { get; set; }
        public int codTipoInvestidor { get; set; }

        [ForeignKey("codTipoInvestidor")]
        public virtual TipoInvestidor TipoInvestidor { get; set; }
    }
}
