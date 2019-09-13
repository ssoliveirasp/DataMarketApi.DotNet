namespace FlyApi.Domain.Repository
{

    interface IUsuarioRepository {

        UserFly Obter (string id);
        void Incluir (UserFly dadosUsuario);
    }

}