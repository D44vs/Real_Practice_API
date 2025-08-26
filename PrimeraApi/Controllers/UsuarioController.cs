using Microsoft.AspNetCore.Mvc;
using PrimeraApi.Models;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private List<Usuario> usuario = new()
        {
            new Usuario {Nombre = "Carlos", Edad = 25, Categoria = "Mayor de Edad"},
            new Usuario {Nombre = "Diego", Edad = 12, Categoria = "Menor de Edad"}
        };


        

        [HttpPost]
        public ActionResult<Usuario> CreateUsuario([FromBody] Usuario usr)
        {
            usr.Categoria = usr.Edad >= 18 ? "Mayor de Edad" : "Menor de Edad";
            usuario.Add(usr);
            return Ok(usuario);
        }
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(usuario);
        }
    };
}
