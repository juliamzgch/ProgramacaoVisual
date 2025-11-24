namespace TUT09_GRUPO_B.Models
{
    public class Musica_B
    {
        public Guid Id_B { get; set; }
        public String Titulo_B { get; set; }
        public String Autor_B { get; set; }
        public int Duracao_B { get; set; }
        public String Ficheiro_B { get; set; }

        public Musica_B(string titulo, string autor, int duracao)
        {
            Titulo_B = titulo;
            Autor_B = autor;
            Duracao_B = duracao;
            Ficheiro_B = "~/wwroot/musicas/" + titulo + ".mp3";
        }

        public Musica_B() : this("S/T", "S/A", 0)
        { }
    }
}
