using System.Drawing;

namespace A05_JuliaMizuguchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXX SLIDE 4 - Construtores");
            Ponto p1 = new Ponto();
            Console.WriteLine("new Ponto() - " + p1);
            Ponto p2 = new Ponto(1, 2);
            Console.WriteLine("new Ponto(1, 2) - " + p2);
            Ponto p3 = new Ponto('x', 3);
            Console.WriteLine("new Ponto('x', 3) - " + p3);
            Ponto p4 = new Ponto('y', 4);
            Console.WriteLine("new Ponto('y', 4) - " + p4);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 4 - COMPOSICÃO");
            // A classe FiguraGeometrica TEM (POSSUI) um Ponto

            // declarar uma variável do tipo (de dados) FiguraGeometrica
            FiguraGeometrica fg1;
            // Inicializar a variável fg1 com um objeto do tipo FiguraGeometrica
            // com o construtor sem parâmetros, ele inicializa o ponto em (0,0)

            // deu erro porque FiguraGeometrica tinha um método abstrato
            // e ela era abstrata
            // fg1 = new FiguraGeometrica();
            // atencao, se tentarmos criar um objeto de uma classe abstrata
            // ele vai dar erro de compilação
            // mas podemos declarar variáveis do tipo dessa classe abstrata
            // e inicializá-las com objetos de classes concretas que herdam dessa classe abstrata
            fg1 = new Rectangulo(); 
            Console.WriteLine("new FiguraGeometrica() - " + fg1);
            

            // usando um ponto existente
            // FiguraGeometrica fg2 = new FiguraGeometrica(p2);

            // 
            FiguraGeometrica fg3 = new FiguraGeometrica(new Ponto(5, 6));

            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 5 - HERANÇA");
            Rectangulo r1 = new Rectangulo();
            Rectangulo r2 = new Rectangulo(p3, 10, 20);
            Rectangulo r3 = new Rectangulo(p4, 20, 10);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 7 - POLIMORFISMO");
            // lista no plural
            List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();
            figuras.Add(fg1);
            figuras.Add(fg2);
            figuras.Add(fg3);
            // como Rectangulo É UMA FiguraGeometrica
            // podemos adicionar a lista de FiguraGeometrica
            figuras.Add(r1);
            figuras.Add(r2);
            figuras.Add(r3);

            // usar o tipo FiguraGeometrica
            // e não var
            foreach (FiguraGeometrica f in figuras)
            {
                // se for FiguraGeometrica, invoco o ToString de FiguraGeometrica
                // se for Rectangulo, invoco o ToString de Rectangulo
                // isso é polimorfismo at its finnest
                Console.WriteLine("\n" + f.ToString());
            }

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();



        }
    }
}
