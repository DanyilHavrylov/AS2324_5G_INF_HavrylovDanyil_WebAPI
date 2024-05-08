using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AS2324_5G_INF_HavrylovDanyil_WebAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AS2324_5G_INF_HavrylovDanyil_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : Controller
    {
        [HttpGet("MultiploIntero")]
        public JsonResult MultiploIntero(int num, int factor)
        {
            string status_result = "OK";
            string message = "Il primo numero è un multiplo intero del secondo";
            var result = num % factor == 0;

            if (result == false)
            {
                status_result = "KO";
                message = "Il primo numero non è un multiplo intero del secondo";
            }

            return Json(new { output = result, status = status_result, message = message });
        }
    }
}
