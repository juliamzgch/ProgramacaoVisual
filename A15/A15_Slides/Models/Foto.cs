namespace TP16_Slides.Models
{
    public class Foto
    {
        public String? Codigo { get; set; }
        public String? Titulo { get; set; }
        public decimal Preco { get; set; }

        public Foto()
        {
            Preco = 6;
        }
    }
}
