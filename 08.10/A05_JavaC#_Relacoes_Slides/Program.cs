using TP02_POO;

namespace A05_JavaC__Relacoes_Slides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXXXX SLIDE 4 - Construtores");
            Ponto p0 = new Ponto();
            Console.WriteLine("new Ponto() - " + p0);
            Ponto p1 = new Ponto(1, 2);
            Console.WriteLine("new Ponto(1, 2) - " + p1);
            Ponto p2 = new Ponto('x', 3);
            Console.WriteLine("new Ponto('x', 3) - " + p2);
            Ponto p3 = new Ponto('y', 4);
            Console.WriteLine("new Ponto('y', 4) - " + p3);


            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 4 - Composição ");

            FiguraGeometrica fg1 = new FiguraGeometrica(new Ponto(10, 20));
            Console.WriteLine("fg1: " + fg1);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 12 - Herança ");

            Rectangulo r1 = new Rectangulo(new Ponto(2, 3), 11, 22);
            Console.WriteLine("r1: " + r1);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 13 - Principio da Substituição ");

            // antes de testar este código remova o abstract de FiguraGeométrica
            FiguraGeometrica fg2 = new FiguraGeometrica(new Ponto(10, 20));
            Console.WriteLine("Está uma FiguraGeometrica em fg2: " + fg2);
            fg2 = r1;
            Console.WriteLine("Está um Retangulo em fg2: " + fg2);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 13 - Polimorfismo");

            Triangulo tri1 = new Triangulo(new Ponto(10, 10), new Ponto(20, 20), new Ponto(30, 10));
            Console.WriteLine(tri1);
            FiguraGeometrica[] figuras = new FiguraGeometrica[5];
            figuras[0] = fg1;
            figuras[1] = fg2;
            figuras[3] = r1;
            figuras[4] = tri1;
            foreach (FiguraGeometrica fg in figuras)
                // POLIMORFISMO :é executado o ToSTring do 
                // tipo de objecto que está em cada referência
                Console.WriteLine(fg);


            foreach (FiguraGeometrica fig in figuras)
            {
                //    // POLIMORFISMO : é executado o Movimentar do 
                //    // tipo de objecto que está em cada referência
                // XXXXX WHATS GOING ON?
                //fig.Movimentar(19, 19);
                //Console.WriteLine(fg);
            }

            figuras[0].Movimentar(10, 10);
            figuras[1].Movimentar(10, 10);
            figuras[3].Movimentar(10, 10);
            figuras[4].Movimentar(10, 10);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 15 - Classes Abstratas e Métodos Abstratos");
            // Gostamos tanto de polimorfismo que inventamos formas de o usar
            // mesmo quando a simples herança não permite
            Console.WriteLine("Triangulo não Ampliado: " + tri1);
            //tri1.Ampliar(2);
            Console.WriteLine("Ampliado: " + tri1);

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 16 - Classes Sealed");
            // Selamos uma classe quando não queremos que outras possam herdar dessa classe
            // keyword sealed: impede queo utras classes possam herdar dela

            Console.WriteLine("\nPrima uma tecla para continuar >");
            Console.ReadKey();
            Console.WriteLine("\nXXXXXXXXXXXXX SLIDE 17 - Interfaces");
            // Gostamos tanto de polimorfismo que inventamos formas de o usar
            // mesmo quando as classes não estão numa hierarquia de herança ...
            // Interfaces são coleções de métodos publicos abstratos
            // são conjuntos de declarações
            // Uma Interface definie um novo tipo de dados ...

            // Ponto não é uma FiguraGeométrica e portanto
            // não podemos por ponto a herdar de FiguraGeométrica
            // mas como queremos movimentar pontos e figuras geométricas ...
            // Usamos Interfaces:
            IMovimentavel[] movimentaveis = new IMovimentavel[4];
            movimentaveis[0] = tri1;
            movimentaveis[1] = r1;
            movimentaveis[2] = new Rectangulo(new Ponto(22, 33), 10, 40);
            movimentaveis[3] = new Triangulo(new Ponto(1, 1), new Ponto(2, 2), new Ponto(3, 1));
            foreach (IMovimentavel m in movimentaveis)
                Console.WriteLine(m);
            Console.WriteLine("\nPrima uma tecla para fechar a janela >");
            Console.ReadKey();

        }

        // PASSAGEM POR VALOR DE VALUE TYPES
        static void DoNotswap(int arg1, int arg2)
        {
            int temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        static void Swap(ref int arg1, ref int arg2)
        {
            int temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        static void DoNotswap(TestaPassagemPorValorOuReferencia arg1, TestaPassagemPorValorOuReferencia arg2)
        {
            TestaPassagemPorValorOuReferencia temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        static void Swap(ref TestaPassagemPorValorOuReferencia arg1, ref TestaPassagemPorValorOuReferencia arg2)
        {
            TestaPassagemPorValorOuReferencia temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        static void SwapAtributeValues(TestaPassagemPorValorOuReferencia arg1, TestaPassagemPorValorOuReferencia arg2)
        {
            int tmp = arg1.i;
            arg1.i = arg2.i;
            arg2.i = tmp;
        }

    }
}
