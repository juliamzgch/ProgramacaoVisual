using Microsoft.AspNetCore.Mvc;
using TUT09_GRUPO_B.Models;
using TUT09_GRUPO_B.Data;

namespace TUT09_GRUPO_B.Controllers
{
    public class MusicaController : Controller
    {
        private static List<Musica_B> musicas = SeedMusica.Seed();
        public IActionResult Index()
        {
            return View(musicas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Musica_B musica)
        {
            musica.Ficheiro_B = "~/wwwroot/musicas/" + musica.Titulo_B.Trim().ToLower() + ".mp3";
            musicas.Add(musica);
            return View("Index", musicas);
        }

        public IActionResult Details(Guid id)
        {
            var musica = musicas.FirstOrDefault(c => c.Id_B == id);
            if (musica is null) return View("Index", musicas);
            return View(musica);
        }

        public IActionResult Edit(Guid id)
        {
            var musica = musicas.FirstOrDefault(c => c.Id_B == id);
            if (musica is null) return View("Index", musicas);
            return View(musica);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Musica_B musica)
        {
            var m = musicas.FirstOrDefault(c => c.Id_B == id);
            if (musica is null) return View("Index", musicas);
            m.Titulo_B = musica.Titulo_B;
            m.Autor_B = musica.Autor_B;
            m.Duracao_B = musica.Duracao_B;
            m.Ficheiro_B = musica.Ficheiro_B;
            return View("Index", musicas);
        }

        public IActionResult Delete(Guid id)
        {
            var musica = musicas.FirstOrDefault(c => c.Id_B == id);
            if (musica is null) return View("Index");
            return View(musica);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            musicas = musicas.Where(c => c.Id_B != id).ToList();
            return View("Index", musicas);
        }

    }
}
