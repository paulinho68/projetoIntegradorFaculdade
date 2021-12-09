
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    [Table("areaInvestimento")]
    public class AreaInvestimento
    {
        [Key]
        public int codAreaInvestimento { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Usuario> Usuarios{ get; set; }

    }
}
