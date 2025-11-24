using Microsoft.AspNetCore.Mvc;
using TUT08_JuliaMizuguchiJulianaLeite.Models;

namespace TUT08_JuliaMizuguchiJulianaLeite.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index()
        {
            List<Musica> musicas = new List<Musica>();
            Musica m1 = new Musica()
            {
                Titulo = "",
                Autor = "",
                Duracao = 0,
                Ficheiro = "~/wwwroot/musicas/"
            };
            Musica m2 = new Musica()
            {
                Titulo = "",
                Autor = "",
                Duracao = 0,
                Ficheiro = "~/wwwroot/musicas/"
            };
            Musica m3 = new Musica()
            {
                Titulo = "",
                Autor = "",
                Duracao = 0,
                Ficheiro = "~/wwwroot/musicas/"
            };
            musicas.Add(m1);
            musicas.Add(m2);
            musicas.Add(m3);
            return View(musicas);
        }
    }
}
