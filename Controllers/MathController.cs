using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AS2223_4G_INF_BuonoFilippo_API.Controllers
{
    [ApiController]
    [Produces("application/Json")]
    [Route("")]
    public class MathController : Controller
    {
        public object valore { get; private set; }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet ("PariDispariGet")]
        public JsonContent PariDispariGet(int value)
        {
            string pariDis;
            if (value % 2 == 1)
            {
                pariDis = "Il valore è dispari";
            }
            else { pariDis = "Il valore è pari"; }

            return Json(new { output = "pariDis", value=value }); 
        }
        [HttpGet("FattorialeGet")]

        public JsonContent FattorialeGet(int valueFatt)
        {
            int fatt = 1;
            for(int i = 1; i <= valueFatt; i++)
            {
                fatt = fatt * i;
            }
            return Json(new { fattoriale = fatt });
        }

    }

}
