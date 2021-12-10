using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int idTipoInvestidor { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }

        public virtual Usuario Usuario{ get; set; }
        public virtual TipoInvestidor TipoInvestidor { get; set; }

    }
}
