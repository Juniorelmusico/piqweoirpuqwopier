using Microsoft.AspNetCore.Mvc;

namespace HolaMundo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("¡Hola Mundo desde ASP.NET Core!");
        }

        [HttpGet("saludo")]
        public ActionResult<string> GetSaludo()
        {
            return Ok("¡Saludos desde ASP.NET Core! 🚀");
        }
    }
}
