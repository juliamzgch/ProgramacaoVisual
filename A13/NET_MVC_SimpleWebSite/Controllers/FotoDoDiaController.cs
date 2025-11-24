using Microsoft.AspNetCore.Mvc;
using NET_MVC_SimpleWebSite.Models;

namespace NET_MVC_SimpleWebSite.Controllers
{
    public class FotoDoDiaController : Controller
    {
        public IActionResult Index()
        {
            FotoDoDia f = new FotoDoDia() { Codigo = 1 , Titulo= "Under Construction", ImagePath = "~/images/UnderContruction1.jpg" };
            return View(f);
        }
    }
}
