using System.Collections.Generic;

namespace ReversoBD.Entities
{
    public class TipoInvestidor
    {
        public int Id{ get; set; }
        public string Nome { get; set; }

        public ICollection<PessoaFisica> PessoasFisicas{ get; set; }
    }
}
