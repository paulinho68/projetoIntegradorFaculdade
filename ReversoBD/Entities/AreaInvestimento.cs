
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("areaInvestimento")]
    public class AreaInvestimento
    {
        [Key]
        public int Id { get; set; }
        public string Nome{ get; set; }
        public virtual ICollection<Usuario> Usuarios{ get; set; }

    }
}
