using A13_SimpleWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace A13_SimpleWebSite.Controllers
{
    public class FotoDoDiaController : Controller
    {
        public IActionResult Index()
        {
            Foto f1 = new Foto()
            {
                Codigo = "123",
                Titulo = "Koala",
                ImagePath = "~/images/koala.jpg"
            };
            // passando o f1 como modelo
            return View(f1);
        }
    }
}
