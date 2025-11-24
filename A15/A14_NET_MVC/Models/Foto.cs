namespace A14_NET_MVC.Models
{
    public class Foto
    {
        public String Codigo { get; }
        public String Titulo { get; set; }
        public String Path { get; set; }
        private static int qtdFotosCriadas;

        public Foto(String titulo)
        {
            Titulo = titulo;
            Path = "~/wwwroot/images/" + Titulo + ".jpg";
            Codigo = qtdFotosCriadas++.ToString();
        }

        public override String ToString()
        {
            return "Id: " + Codigo +
                "\t| Titulo: " + Titulo +
                "\t| Path: " + Path;
        }
    }
}
