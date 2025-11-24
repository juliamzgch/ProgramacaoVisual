using Slides_ASPNET_CRUD.Models;

namespace Slides_ASPNET_CRUD.Data
{
    public static class SeedFotos
    {
        public static List<Foto>Seed() => new List<Foto>()
        {
            new Foto("Deserto", 1.1m),
            new Foto("Koala", 1.2m),
            new Foto("Tulips", 1.3m),
        };
    }
}
