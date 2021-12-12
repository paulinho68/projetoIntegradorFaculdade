using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReversoBD.Entities
{
    public class Telefone
    {
        public int Id { get; set; }
        public int IdUsuario{ get; set; }
        public string Numero { get; set; }

        public virtual Usuario Usuario{ get; set; }

    }
}
