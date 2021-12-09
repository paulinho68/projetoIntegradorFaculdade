using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    public class PessoaJuridica : Usuario
    {
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public Boolean analisado { get; set; }
    }
}
