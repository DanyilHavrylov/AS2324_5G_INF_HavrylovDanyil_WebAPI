using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System;

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
            bool result = num % factor == 0;

            if (result == false)
            {
                status_result = "KO";
                message = "Il primo numero non è un multiplo intero del secondo";
            }

            return Json(new { output = result, status = status_result, message = message });
        }

        [HttpGet("Potenza")]
        public JsonResult Potenza(int b, int esponente)
        {
            string status_result = "OK";
            string message = "";
            bool result = true;

            if (esponente < 0)
            {
                status_result = "KO";
                message = "L'esponente dato è negativo";
                result = false;
            }
            else
            {
                int res = 1;
                for (int i = 0; i < esponente; i++)
                {
                    res *= b;
                }
                
                message = $"Il risultato della elevazione di {b} alla {esponente} equivale a {res}";
            }

            return Json(new { output = result, status = status_result, message = message });
        }

        [HttpGet("AnnoBisestile")]
        public JsonResult AnnoBisestile(int anno)
        {
            string status_result = "OK";
            string message = "L'anno è bisestile";
            bool result = anno % 4 == 0 && (anno % 100 != 0 || anno % 400 == 0);

            if (result == false)
            {
                status_result = "KO";
                message = "L'anno non è bisestile";
            }

            return Json(new { output = result, status = status_result, message = message });
        }
    }
}
