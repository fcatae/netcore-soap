using System.ServiceModel;

namespace webxml.Models
{
    [ServiceContract]
    public interface IPedidoService
    {
        [OperationContract]
        Pedido[] ListarPedidos();
    }
}