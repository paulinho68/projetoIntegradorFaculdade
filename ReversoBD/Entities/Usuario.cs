using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{ 
    public class Usuario
    {
        public int Id{ get; set; }
        public string Email{ get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Telefone> Telefones{ get; set; }
        public virtual PessoaFisica PessoaFisica{ get; set; }

    }
}
