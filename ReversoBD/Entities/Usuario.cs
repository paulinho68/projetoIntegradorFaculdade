using System.Collections.Generic;

namespace ReversoBD.Entities
{ 
    public class Usuario
    {
        public int Id{ get; set; }
        public string Email{ get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Telefone> Telefones{ get; set; }
        public virtual PessoaFisica PessoaFisica{ get; set; }
        public virtual PessoaJuridica PessoaJuridica{ get; set; }
        public virtual Endereco Endereco{ get; set; }

        public virtual ICollection<AreaInvestimento> AreasInvestimentos { get; set; }

    }
}
