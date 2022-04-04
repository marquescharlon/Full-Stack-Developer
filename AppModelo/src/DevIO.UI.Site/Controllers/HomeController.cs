using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRespository;
        public HomeController(IPedidoRepository pedidoRespository )
        {
            _pedidoRespository = pedidoRespository;

        }

        public IActionResult Index()
        {

            var pedido = _pedidoRespository.ObterPedido();

            return View();
        }
    }
}
