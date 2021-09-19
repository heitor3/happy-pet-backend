using Web.Api.HappyPet.Models;

namespace Web.Api.HappyPet.Repositories
{
    public interface IUsuario
    {
        void Create(Usuario usuario);

        Usuario Login(string email, string senha);

    }
}
