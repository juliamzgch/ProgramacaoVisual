using A16_NETMVC_CRUD.Models;

namespace A16_NETMVC_CRUD.Data
{
    public static class SeedFotos
    {
        // para podermos modificar a nossa coleção
        // (criar e apagar registros)
        // temos de usar um objeto static que seja
        // partilhado por todos os controladores..
        // lembram-se que por cada request
        // é criado um objeto do controlador invocado
        // e se a coleção não fosse static.. .
        // cada novo controlador iria trabalhar
        // com uma nova (a sua instancia da) coleção
        public static List<Foto> Seed() => new()
        {
            new Foto("Desert", 1.1m),
            new Foto("Koala", 1.2m),
            new Foto("Tulips", 1.3m)
        };
    }
}
