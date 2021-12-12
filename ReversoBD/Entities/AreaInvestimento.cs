
using System.Collections.Generic;

namespace ReversoBD.Entities
{
    public class AreaInvestimento
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public virtual ICollection<AreaInvestimentoUsuario> AreasInvestimentosUsuarios { get; set; }

    }
}
