using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RestApiModelDDD.API.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult HealthCheck()
            => Ok(new { message = "Tudo OK" });
        
    }
}