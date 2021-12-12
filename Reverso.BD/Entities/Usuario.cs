using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        public int codUsuario{ get; set; }
        public string email{ get; set; }
        public string senha { get; set; }

        public virtual ICollection<Telefone> Telefones{ get; set; }
        public virtual ICollection<AreaInvestimento> AreasInvestimentos{ get; set; }

    }
}
