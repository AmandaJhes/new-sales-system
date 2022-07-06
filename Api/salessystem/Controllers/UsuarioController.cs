using Microsoft.AspNetCore.Mvc;
using salessystem.Model;

namespace salessystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>{
                new Usuario{Nome = "Lucas", Id = 1, DataNascimento = DateTime.Now}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(Usuarios());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }
    }
}