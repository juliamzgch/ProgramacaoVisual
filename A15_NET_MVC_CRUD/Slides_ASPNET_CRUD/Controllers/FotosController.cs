using Microsoft.AspNetCore.Mvc;
using Slides_ASPNET_CRUD.Models;
using Slides_ASPNET_CRUD.Data;

namespace Slides_ASPNET_CRUD.Controllers
{
    public class FotosController : Controller
    {
        private static List<Foto> fotos = SeedFotos.Seed();

        public IActionResult Index()
        {
            return View(fotos);
        }

        [HttpPost]
        public IActionResult Index(string tituloFoto)
        {
            if (string.IsNullOrEmpty(tituloFoto)) return View(fotos);

            var filteredFotos = fotos.Where(c =>
                    c.Titulo.ToLower().Contains(tituloFoto.ToLower(),
                    StringComparison.InvariantCulture)).ToList();
            return View(filteredFotos);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Foto foto)
        {
            fotos.Add(foto);
            return View("Index", fotos);
        }

        public IActionResult Details(Guid id)
        {
            var foto = fotos.FirstOrDefault(c => c.Id == id);
            if (foto is null) return View("Index", fotos);
            return View(foto);

        }

        public IActionResult Edit(Guid id)
        {
            var foto = fotos.FirstOrDefault(c => c.Id == id);
            if (foto is null) return View("Index", fotos);
            return View(foto);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Foto foto)
        {
            var f = fotos.FirstOrDefault(c => c.Id == id);
            if (f is null) return View("index");
            f.Titulo = foto.Titulo;
            f.Preco = foto.Preco;
            f.Path= "~/wwwroot/images/" + f.Titulo + "jpg";
            return View("Index", fotos);
        }

        public IActionResult Delete(Guid id)
        {
            var foto = fotos.FirstOrDefault(c => c.Id == id);
            if (foto is null) return View("index");
            return View(foto);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            fotos = fotos.Where(c => c.Id != id).ToList();
            return View("Index", fotos);
        }



    }
}
