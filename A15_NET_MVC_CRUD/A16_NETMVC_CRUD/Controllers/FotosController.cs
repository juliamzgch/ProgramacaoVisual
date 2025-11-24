using A16_NETMVC_CRUD.Data;
using A16_NETMVC_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace A16_NETMVC_CRUD.Controllers
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
                           c.Nome.ToLower().Contains(tituloFoto.ToLower(),
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
            foto.Path = "~/wwwroot/images/" + foto.Nome + ".jpg";
            fotos.Add(foto);
            return View("Index", fotos);
        }

        public IActionResult Details(Guid id)
        {
            var foto = fotos.FirstOrDefault(c => c.Id == id);
            if (foto == null) return View("Index", fotos);
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
            if (foto is null) return View("Index");
            f.Nome = foto.Nome;
            f.Preco = foto.Preco;
            return View("Index", fotos);
        }

        public IActionResult Delete(Guid id)
        {
            var foto = fotos.FirstOrDefault(c => c.Id == id);
            if (foto is null) return View("Index");
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
