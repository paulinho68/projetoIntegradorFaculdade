using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversoBD.Entities
{
    public class AreaInvestimentoUsuario
    {
        public int Id;
        public int IdAreaInvestimento;
        public int IdUsuario;

        public AreaInvestimento AreaInvestimento;
        public Usuario Usuario;
    }
}
