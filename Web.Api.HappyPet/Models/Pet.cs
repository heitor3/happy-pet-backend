using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.HappyPet.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        public string Nome { get; set; }

        public string Idade { get; set; }

        public string Descricao { get; set; }

        public int UsuarioId { get; set; }

        public int PorteId { get; set; }

        public int EspecieId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Porte Porte { get; set; }

        public virtual Especie Especie { get; set; }

    }
}
