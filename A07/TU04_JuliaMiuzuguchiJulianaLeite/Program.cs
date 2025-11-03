namespace TU04_JuliaMiuzuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************" +
                              "\n*** 2 PROPRIEDADES:" +
                              "\n*      Encapsulam (encobrem) os campos "+
                              "\n*      seja implicitamente," +
                              "\n*      sem os declarar explicitamente:" +
                              "\n*          public DataType PropName { get; set; }" +
                              "\n*      seja explicitamente, declarando o campo:" +
                              "\n*          private int nomeDoCampo;" +
                              "\n*          public int NomeDpCampo" +
                              "\n*          {" +
                              "\n*                get { return myVar; }" +
                              "\n*                set { myVar = value; }" +
                              "\n*          }");

            Console.WriteLine("**********************" +
                                      "\n*** 2.1 Classes Ponto_JMJL e FiguraGeometrica_JMJL:" +
                                      "\n***     Note a utilizaçãp de Propriedades com campo implicito," +
                                      "\n***     vulgo propriedades implicitas uma vez que" +
                                      "\n***     não necessitamos de codificar nada além de retornar" +
                                      "\n***     o estado do campo");

            Ponto_JMJL p1_JMJL = new Ponto_JMJL();
            Ponto_JMJL p2_JMJL = new Ponto_JMJL(1, 2);
            Console.WriteLine(p1_JMJL + " - " + p2_JMJL);

            // Note o acesso transparente através da propriedade public do objeto, sem ()
            p2_JMJL.X_JMJL = 10;
            p2_JMJL.Y_JMJL = 20;
            // Note a invocação de um método com ()
            p1_JMJL.Desloca_JMJL(3, 4);
            Console.WriteLine(p1_JMJL + " - " + p2_JMJL);

            FiguraGeometrica_JMJL fg1_JMJL = new FiguraGeometrica_JMJL();
            FiguraGeometrica_JMJL fg2_JMJL = new FiguraGeometrica_JMJL(1, 2);
            FiguraGeometrica_JMJL fg3_JMJL = new FiguraGeometrica_JMJL(p1_JMJL);
            Console.WriteLine(fg1_JMJL + " - " + fg2_JMJL + " - " + fg3_JMJL);
            // Note o acesso transparente através da propriedade public do objeto, sem ()
            fg1_JMJL.Origem_JMJL = p1_JMJL;
            fg2_JMJL.Origem_JMJL = p2_JMJL;
            fg3_JMJL.Origem_JMJL = new Ponto_JMJL(55, 66);
            Console.WriteLine(fg1_JMJL.Origem_JMJL + 
                      " - " + fg2_JMJL.Origem_JMJL +
                      " - " + fg3_JMJL.Origem_JMJL);

            fg1_JMJL.Desloca_JMJL(100, 200);
            Console.WriteLine(fg1_JMJL + " - " + fg2_JMJL + " - " + fg3_JMJL);

            Console.WriteLine("***************************" +
                              "\n*** 2.3 Classes Circulo_JMJL, Retangulo_JMJL e Quadrado_JMJL" +
                              "\n***     Note a utilização da Propriedade com campo EXPLICITO," +
                              "\n***     Lado do quadrado");

            Circulo_JMJL c1_JMJL = new Circulo_JMJL();
            Retangulo_JMJL r1_JMJL = new Retangulo_JMJL();
            Quadrado_JMJL q1_JMJL = new Quadrado_JMJL();
            Console.WriteLine(c1_JMJL + "\n" + r1_JMJL + "\n" + q1_JMJL);

            c1_JMJL.Desloca_JMJL(10, 20);
            r1_JMJL.Desloca_JMJL(100, 200);
            q1_JMJL.Desloca_JMJL(1000, 2000);
            Console.WriteLine(c1_JMJL + "\n" + r1_JMJL + "\n" + q1_JMJL);

            Console.WriteLine("\n**********************************************" +
                              "\n*** 3.1 Classe Linha_JMJL");
            Linha_JMJL l1_JMJL = new Linha_JMJL() { Inicio_JMJL = p1_JMJL, Fim_JMJL = p2_JMJL };
            Console.WriteLine("De: " + l1_JMJL.Inicio_JMJL + " a " + l1_JMJL.Fim_JMJL);
            Linha_JMJL l2_JMJL = new Linha_JMJL() { Fim_JMJL = new Ponto_JMJL(20, 10) };
            Console.WriteLine("De: " + l2_JMJL.Inicio_JMJL + " a " + l2_JMJL.Fim_JMJL);
            Linha_JMJL l3_JMJL = new Linha_JMJL() { Inicio_JMJL = new Ponto_JMJL(30, 40) };
            Console.WriteLine("De: " + l3_JMJL.Inicio_JMJL + " a " + l3_JMJL.Fim_JMJL);

        } // chaveta que fecha o Main
    } // chaveta que fecha a classe Program
}
