using FlyApi.Domain.Entity;

namespace FlyApi.Domain.Repository
{

    public interface IUsuarioRepository {

        UserFly Obter (string id);
        void Incluir (UserFly dadosUsuario);
    }

}