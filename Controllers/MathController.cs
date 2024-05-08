using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_HavrylovDanyil_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public JsonResult MultiploIntero(int num, int factor)
        {
            var result = num % factor == 0;
            return new JsonResult(new { output = result, status = result? "OK" : "KO", message = result? "Il primo numero è un multiplo intero del secondo" : "Il primo numero non è un multiplo intero del secondo" });
        }
    }
}
