using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HappyPet.Context;
using Web.Api.HappyPet.Models;

namespace Web.Api.HappyPet.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(Usuario usuario)
        {
            _appDbContext.Usuario.Add(usuario);
            _appDbContext.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            var user = _appDbContext.Usuario
                .FirstOrDefault(x => x.Email == email && x.Senha == senha);

            return user;
        }
    }
}
