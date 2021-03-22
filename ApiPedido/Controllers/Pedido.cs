using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPedido.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Pedido : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]> ListarPedido()
        {
            string[] lista = new string[2];
            lista[0] = "pedido 1";
            lista[1] = "pedido 2";
            return Ok(lista);
        }
    }
}
