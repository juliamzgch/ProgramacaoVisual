using Microsoft.AspNetCore.Mvc;
using TUT7_JuliaMizuguchiJulianaLeite.Models;

namespace TUT7_JuliaMizuguchiJulianaLeite.Controllers
{
    public class FotoDoDiaController : Controller
    {
        public IActionResult Index()
        {
            Foto f = new Foto
            {
                Codigo = "ROMA 01",
                Titulo = "Coliseu"
            };
            return View(f);
        }
    }
}
