using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("pessoaJuridica")]
    public class PessoaJuridica
    {
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public Boolean analisado { get; set; }
    }
}
