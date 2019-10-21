using System.ServiceModel;

namespace webxml.Models
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        bool Login(Login login);

        [OperationContract]
        User[] ListarUsuarios();
    }
}