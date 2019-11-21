using webxml.Models;
using System;

namespace webxml
{
    public class PedidoService : IPedidoService
    {
        public Pedido[] ListarPedidos()
        {
            return new Pedido[] { 
                new Pedido { Id = 1, Username = "Fabricio", Status = "complete" }, //, TotalPrice = 100.01M },
                new Pedido { Id = 2, Username = "Fabio", Status = "complete" }, //, TotalPrice = 200.00M },
                new Pedido { Id = 3, Username = "Fernando", Status = "new" }, //, TotalPrice = 5.73M },
                new Pedido { Id = 4, Username = "Fernando", Status = "new" }, //, TotalPrice = 2.97M },
                new Pedido { Id = 5, Username = "Fabricio", Status = "new" } //, TotalPrice = 8700.54M }                
            };
        }
    }
}