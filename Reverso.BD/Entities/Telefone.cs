using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("telefone")]
    public class Telefone
    {
        [Key]
        public int codTelefone { get; set; }
        public string telefone { get; set; }

        public int codUsuario { get; set; }
        [ForeignKey("codUsuario")]
        public virtual Usuario Usuario{ get; set; }

    }
}
