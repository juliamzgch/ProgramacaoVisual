namespace T02_JuliaMizuguchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Season0_JM estação0 = Season0_JM.Fall;
            Console.WriteLine(estação0); // escreve ‘Fall’
            Console.WriteLine((int)estação0); // escreve ‘2’
            Season1_JM estação1 = Season1_JM.Fall;
            Console.WriteLine(estação1); // escreve ‘Fall’
            Console.WriteLine((int)estação1); // escreve ‘5’
            Season2_JM estação2 = Season2_JM.Autumn;
            Console.WriteLine(estação2); // escreve ‘Autumn’
            Console.WriteLine((int)estação2); // escreve ‘2’
            Season3_JM estação3 = Season3_JM.Fall;
            Console.WriteLine(estação3); // escreve ‘Fall’
            Console.WriteLine((int)estação3); // escreve ‘5’

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Livro_JM livro1_JM;
            // NOTE QUE como ainda nao codificamos nenhum construtor
            // na classe Livro_JM, o C# (tal como o Java) oferece o
            // construtor sem parametros
            livro1_JM = new Livro_JM();

            Livro_JM livro2_JM = new Livro_JM();
            Livro_JM livro3_JM = new Livro_JM();

            Cd_JM cd1_JM = new Cd_JM();
            Dvd_JM dvd1_JM = new Dvd_JM();

            livro2_JM = new Livro_JM("IU_000000001",
                                     "Memorial do Convento",
                                     "José Saramago",
                                     25.5M,
                                     3);

            livro3_JM = new Livro_JM("IU_000000002",
                                     "O Conde de Abranhos",
                                     "Eca de Queiros",
                                     15.3M,
                                     2);

            cd1_JM = new Cd_JM("IU_100000001",
                               "A Todo Vapor",
                               "Gal Costa",
                               15,
                               32.9M,
                               3);

            dvd1_JM = new Dvd_JM("IU_200000001",
                               "A Vida é Bela",
                               "Roberto Benigni",
                               116,
                               23.4,
                               4);

            Console.WriteLine("\n**************\nLIVROS EM STOCK:");
            Console.WriteLine("\n*** LIVRO: " + livro1_JM.GetIdentificadorUnico_JM()
                + "\n* " + livro1_JM.GetTitulo_JM()
                + "\n* " + livro1_JM.GetAutor_JM()
                + "\n* " + livro1_JM.GetPreco_JM()
                + "\n* " + livro1_JM.GetExistencias_JM());
            Console.WriteLine("\n*** LIVRO: " + livro2_JM.GetIdentificadorUnico_JM()
                + "\n* " + livro2_JM.GetTitulo_JM()
                + "\n* " + livro2_JM.GetAutor_JM()
                + "\n* " + livro2_JM.GetPreco_JM()
                + "\n* " + livro2_JM.GetExistencias_JM());

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\n*** CD: " + cd1_JM.GetIdentificadorUnico_JM()
                + "\n* " + cd1_JM.GetTitulo_JM()
                + "\n* " + cd1_JM.GetInterprete_JM()
                + "\n* " + cd1_JM.GetDuracao_JM()
                + "\n* " + cd1_JM.GetPreco_JM()
                + "\n* " + cd1_JM.GetExistencias_JM());
            Console.WriteLine("\n*** DVD: " + dvd1_JM.GetIdentificadorUnico_JM()
                + "\n* " + dvd1_JM.GetTitulo_JM()
                + "\n* " + dvd1_JM.GetRealizador_JM()
                + "\n* " + dvd1_JM.GetDuracao_JM()
                + "\n* " + dvd1_JM.GetPreco_JM()
                + "\n* " + dvd1_JM.GetExistencias_JM());

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            livro1_JM.SetTitulo_JM("Os Lusiadas");
            livro1_JM.SetAutor_JM("Luiz Vaz de Camoes");
            livro1_JM.SetPreco_JM(30.99M);
            livro1_JM.SetExistencias_JM(1);

            livro2_JM.SetPreco_JM(35.99M);
            livro2_JM.SetExistencias_JM(5);
            livro3_JM.SetPreco_JM(20.89M);
            livro3_JM.SetExistencias_JM(1);

            Console.WriteLine("\n*** LIVRO: " + livro1_JM.GetIdentificadorUnico_JM()
                + "\n* " + livro1_JM.GetTitulo_JM()
                + "\n* " + livro1_JM.GetAutor_JM()
                + "\n* " + livro1_JM.GetPreco_JM()
                + "\n* " + livro1_JM.GetExistencias_JM());
            Console.WriteLine("\n*** LIVRO: " + livro2_JM.GetIdentificadorUnico_JM()
                + "\n* " + livro2_JM.GetPreco_JM()
                + "\n* " + livro2_JM.GetExistencias_JM());
            Console.WriteLine("\n*** LIVRO: " + livro3_JM.GetIdentificadorUnico_JM()
                + "\n* " + livro3_JM.GetPreco_JM()
                + "\n* " + livro3_JM.GetExistencias_JM());

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            cd1_JM.SetPreco_JM(30.99M);
            cd1_JM.SetExistencias_JM(4);
            dvd1_JM.SetPreco_JM(21.99);
            dvd1_JM.SetExistencias_JM(1);

            Console.WriteLine("\n*** CD: " + cd1_JM.GetIdentificadorUnico_JM()
                + "\n* " + cd1_JM.GetPreco_JM()
                + "\n* " + cd1_JM.GetExistencias_JM());
            Console.WriteLine("\n*** DVD: " + dvd1_JM.GetIdentificadorUnico_JM()
                + "\n* " + dvd1_JM.GetPreco_JM()
                + "\n* " + dvd1_JM.GetExistencias_JM());

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine(livro1_JM
                            + "\n" + livro2_JM
                            + "\n" + livro3_JM);
            Console.WriteLine("\n" + cd1_JM);
            Console.WriteLine("\n" + dvd1_JM);

            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();
        }
    }
}
