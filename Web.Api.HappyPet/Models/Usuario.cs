using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.HappyPet.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Whatsapp { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Senha { get; set; }

        [NotMapped]
        public string ConfirmaSenha { get; set; }
    }
}
