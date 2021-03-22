using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Catalogo : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]> RetornarProduto()
        {
            string[] lista = new string[3];
            lista[0] = "Chocolate";
            lista[1] = "HD Externo";
            lista[2] = "Mouse";
            return Ok(lista);
        }
    }
}
