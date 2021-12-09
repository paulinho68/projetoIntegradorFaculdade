using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("endereco")]
    public class Endereco
    {
        [Key]
        public int codEndereco { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string cep{ get; set; }
        public string pais { get; set; }
        public int codUsuario { get; set; }
        [ForeignKey("codUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
