using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public Boolean Analisado { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
