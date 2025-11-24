using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP16_Slides.Models;

namespace TP16_Slides.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<String> lista = new List<String>() {
            "aqui vai encontrar", "as melhores fotos" };
            ViewData["Objecto"] = lista;
            ViewData["Texto1"] = " Bem Vindo ao FotoShopping";
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PorTitulo(string titulo)
        {
            Foto f = new Foto
            {
                Codigo = "ABC000001",
                Titulo = titulo
            };
            return View(f);
        }

        public IActionResult ListarFotos()
        {
            List<Foto> listaDeFotos = new List<Foto>();
            Foto f1 = new Foto { Titulo = "North Sea", Codigo = "NS111" };
            Foto f2 = new Foto { Titulo = "Turtle", Codigo = "TU222" };
            Foto f3 = new Foto { Titulo = "Sun Shining", Codigo = "SUSH333" };
            listaDeFotos.Add(f1);
            listaDeFotos.Add(f2);
            listaDeFotos.Add(f3);
            return View(listaDeFotos);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}