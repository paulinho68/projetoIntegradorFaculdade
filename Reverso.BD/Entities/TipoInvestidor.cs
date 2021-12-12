using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("tipoInvestidor")]
    public class TipoInvestidor
    {
        [Key]
        public int codTipoInvestidor { get; set; }
        public string nome { get; set; }

        public ICollection<PessoaFisica> pessoasFisicas{ get; set; }
    }
}
