namespace A16_NETMVC_CRUD.Models
{
    public class Foto
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public String Path { get; set; }

        public Foto(String nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Path = "~/wwwroot/images/" + nome + ".jpg";
            Id = Guid.NewGuid();
        }

        // se criarmos OUTROS CONSTRUTORES
        // numa classe MODEL
        // T E M O S
        // de criar
        // S E M P R E
        // um construtor sem parametros
        public Foto() : this("Sem Nome", 0.0m)
        { }
        
        

    }
}
