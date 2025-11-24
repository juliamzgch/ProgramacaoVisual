using TUT09_GRUPO_B.Models;

namespace TUT09_GRUPO_B.Data
{
    public static class SeedMusica
    {

        public static List<Musica_B> Seed() => new()
        {
            new Musica_B("Pensando Bem", "5 a Seco", 199),
            new Musica_B("Quadro Verde", "Rubel", 422),
            new Musica_B("Tenta Acreditar", "Anavitória", 234)
        };
    }
}
