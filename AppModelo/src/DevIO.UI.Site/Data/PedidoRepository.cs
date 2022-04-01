using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.UI.Site.Models;

namespace DevIO.UI.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public  Pedido ObterPedido()
        {
            return new Pedido();
        }
    }

    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
