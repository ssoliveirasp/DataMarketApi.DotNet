
using FlyApi.Domain.Entity;
using FlyApi.Domain.Repository;

namespace FlyApi.Infra.Repository
{
    public class UsuarioRepositorySQL : IUsuarioRepository
    {
        public UsuarioRepositorySQL()
        {

        }

        public void Incluir(UserFly dadosUsuario)
        {

        }

        public UserFly Obter(string id)
        {
            return new UserFly();
        }
    }
}