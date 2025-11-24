namespace Slides_ASPNET_CRUD.Models
{
    public class Foto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public string Path { get; set; }

        public Foto(String titulo, decimal preco)
        {
            Titulo = titulo;
            Preco = preco;
            Id = Guid.NewGuid();
            Path = "~/wwwroot/images/" + titulo + "jpg";
        }

        public Foto() : this ("Sem Titulo", 0.0m){ }
    }
}
