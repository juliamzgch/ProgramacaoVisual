using System.Diagnostics;
using A14_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace A14_NET_MVC.Controllers
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
            //ViewBag.Welcome = "Seja bem-vindo!";
            //Foto f = new Foto("Koala");
            //ViewBag.MyFoto = f;
            List<String> lista = new List<String>()
            {
                "aqui vai encontrar", //[0] 
                "as melhores fotos"   //[1]
            };
            ViewData["ObjetoLista"] = lista;
            ViewData["Texto1"] = "Bem-vindo ao FotoShopping";
            return View();
        }

        public IActionResult PorTitulo(String titulo)
        {
            Foto f = new Foto(titulo);
            return View(f);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
