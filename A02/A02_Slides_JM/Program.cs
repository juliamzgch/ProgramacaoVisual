
// Tal como em Java, a linhas antecedidas por //
// não são consideradas código pelo compilador
// Para comentar e descomentar código no VS
// selecciona-se o código e Ctrl k + Ctrl C
// Em C# usam-se namespaces com uma função equivalente
// aos packages do JAVA.
// A diretiva using do C# é semelhante ao import do JAVA e
// permite usar tipos de outro namespace
// sem ter de os especificar

using System;
using System.Collections.Generic;
using System.Drawing;
namespace A02_Slides_JM
{
    // Em C# os comentários em XML, equivalentes ao Javadoc
    // do Java, iniciam-se por /// e originam ficheiros em XML
    /// <summary>
    /// ola mundo
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + "\nNote que o Main em C# segue a convenção de que todos os\r\nidentificadores públicos começam por maiúsculas (notação PascalCase)");
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();
            Console.WriteLine("\nXXXXX - TIPOS DE DADOS – Slide 7" +
            "\n\nUm tipo de dados define um conjunto de valores e as" +
            "\n operações que podemos executar com esses valores");
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX – IDENTIFICADORES Slide 7" +
            "\n\nUm identificador é um nome que damos " +
            "\n a uma entidade de um programa de c#" +
            "\n como classes, variáveis ou métodos" +
            "\nEm C# todos as entidades públicas (ou none) " +
            "\n têm os seus nomes em PascalCase " +
            "\n (PrimeiraLetraDeCadaPalavraMaiuscula" +
            "\n\nEm C# as entidades que não sejam públicas (ou none) " +
            "\n têm os seus nomes em camelCase " +
            "\n (primeiraLetraDaPrimeiraPalavraMinuscula");
            Console.WriteLine("\nMandam as práticas de bem programar que" +
            "\n\nNão usemos no código caracteres específicos do português" +
            "\n mas podemos usá-los nos comentários ou nas saídas" +
            "\n Exemplo: não usar Ç ã, á, í etc." +
            "\n\nNão usemos acrónimos nem abreviaturas nos identificadores" +
            "\n Exemplo: não usar num para numero, opc para opcao etc." +
            "\n\nEscolhemos cuidadosamente os nomes das variáveis " +
            "\n por forma a identificarem a entidade envolvida." +
            "\n\nEscolhemos verbos para ações, procedimento e funções" +
            "\n Exemplo: CalculaMedia, TrocaValores" +
            "\n\nEscolhemos substantivos para classes, e variáveis" +
            "\n Exemplo: Aluno, Escola, posicao, media ");
            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX - TIPOS DE DADOS POR VALOR E POR REFERÊNCIA – Slide 8" +
            "\n\ntipo por valor (int, double char etc): " +
            "\n na variável é escrito um valor" +
            "\n\ntipo por referência (Int32, Double, Char etc): " +
            "\n na variável é escrita uma referência " +
            "\n (o endereço de memória onde está o objeto)" +
            "\n\nEm c# os tipos simples (incorporados ou built-in) " +
            "\n podem ser vistos como nomes alternativos (alias)" +
            "\n para as classes existentes." +
            "\n\nOs tipos simples são tipos por valor " +
            "\n significando que as suas variáveis armazenam valores");
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();

            int variavel1;
            variavel1 = 1;
            int variavel2 = 2;
            int tmp = variavel1;
            variavel1 = variavel2;
            variavel2 = tmp;
            Console.WriteLine("\nXXXXX – slide 9 - Instruções e operadores de atribuição" +
            "\nvariável 1 = " + variavel1 +
            "\nvariável 2 = " + variavel2);
            variavel1++;
            variavel2--;
            Console.WriteLine("\nvariável 1 = " + variavel1 +
            "\nvariável 2 = " + variavel2);
            variavel1 += 10;
            variavel2 -= 20;
            Console.WriteLine("\nvariável 1 = " + variavel1 +
            "\nvariável 2 = " + variavel2);
            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX Slide 10 - Operador condicional ? :");
            Console.WriteLine("\nEscreva o nome de um mês em minúsculas >");
            string str = Console.ReadLine();
            Console.WriteLine(str == "fevereiro" ? "tem 28 dias" : "tem 30 ou 31 dias");
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();

            Console.WriteLine(variavel1 > 10 ? "maior que dez" : "menor ou igual a dez.");
            Console.WriteLine("\n" + variavel1);
            variavel2 = variavel2 < 0 ? -1 : 1;
            Console.WriteLine(variavel2);

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX Slide 11 - seleção if-else");
            switch (str) // str tem de ser de um tipo enumeravel ou string
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("tem 31 dias");
                    break;
                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    Console.WriteLine("tem {0} dias", 30);
                    break;
                case "fevereiro":
                    Console.WriteLine("tem {0} ou {1} dias", 28, 29);
                    break;
                default:
                    Console.WriteLine("mês desconhecido");
                    break;
            }
            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nDigite um número de 1 a 5: ");
            string stringTmp_JM = Console.ReadLine();
            int inteiro_JM = int.Parse(stringTmp_JM);

            switch (inteiro_JM)
            {
                case 1:
                    Console.WriteLine("UM");
                    break;
                case 2:
                    Console.WriteLine("DOIS");
                    break;
                case 3:
                    Console.WriteLine("TRÊS");
                    break;
                case 4:
                    Console.WriteLine("QUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("DEU BRONCA.");
                    break;
            }

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX Slide 12 - seleção if-else");
            if (str == "fevereiro")
            {
                // se tiver mais de uma instrução temos de
                //criar um bloco com chavetas
                Console.WriteLine("tem {0} dias", 28);
                Console.WriteLine("Se o bloco da cláusula" +
                "\ntiver duas ou mais instruções" +
                "\n temos de as agrupar num bloco");
            }
            else if ((str == "abril") ||
                    (str == "junho") ||
                    (str == "setembro") ||
                    (str == "novembro"))
                // se a intrução for simples não precisa de chavetas
                Console.WriteLine("tem {0} dias", 30);
            else
                Console.WriteLine("tem {0} dias", 31);

            Console.WriteLine("Prima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nDigite um número de 1 a 5: ");
            stringTmp_JM = Console.ReadLine();
            double numero_JM = double.Parse(stringTmp_JM);

            if (numero_JM >= 0.0 && numero_JM < 1.0)
                Console.WriteLine("0");
            else if (numero_JM >= 1.0 && numero_JM < 2.0)
                Console.WriteLine("1");
            else if (numero_JM >= 2.0 && numero_JM < 3.0)
                Console.WriteLine("2");
            else if (numero_JM >= 3.0 && numero_JM < 4.0)
                Console.WriteLine("3");
            else if (numero_JM >= 4.0 && numero_JM < 5.0)
                Console.WriteLine("4");
            else if (numero_JM >= 5.0 && numero_JM < 6.0)
                Console.WriteLine("5");
            else
                Console.WriteLine("DEU BRONCA.");

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 13 - Quando usar qual delas?");
            Console.WriteLine("\nOperador condicional ?" +
            "\n Sempre que o resultado da avaliação seja atribuível a " +
            "\n a uma variável e facilite a leitura." +
            "\n\nSwitch" +
            "\n Quando str for uma String ou um enumerável." +
            "\n\nif /else" +
            "\n Quando não pudermos usar os dois anteriores");
            Console.WriteLine("\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 14 - Estruturas de Repetição - foreach");
            Console.WriteLine("Mais eficiente, usamos sempre que possível" +
                "\nInfelizmente só podemos usá-la para iterar coleções");
            string str1 = "abcdefgh";
            // ler para cada char chamado s no código abaixo
            // existente na coleção str1
            // execute o código do bloco abaixo
            foreach (char s in str1)
            {
                Console.Write(" {0}-", s);
                Console.Write(" {0}-", s + 1);
            }
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("Digite seu nome completo: ");
            stringTmp_JM = Console.ReadLine();

            foreach (char s in stringTmp_JM)
            {
                Console.Write("\n" + s);
            }

            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 14 - Estruturas de Repetição - for");
            Console.WriteLine("Usamos quando não podemos usar o foreach" +
            "\n Infelizmente só podemos usá-la quando sabemos" +
            "\n antecipadamente quantas vezes o ciclo deve ser executado");

            int i = 0;
            for (i = 0; i < 10; i++)
                Console.Write(" {0}-", i);

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\nDigite um número de 1 a 5: ");
                stringTmp_JM = Console.ReadLine();
                numero_JM = double.Parse(stringTmp_JM);

                if (numero_JM >= 0.0 && numero_JM < 1.0)
                    Console.WriteLine("0");
                else if (numero_JM >= 1.0 && numero_JM < 2.0)
                    Console.WriteLine("1");
                else if (numero_JM >= 2.0 && numero_JM < 3.0)
                    Console.WriteLine("2");
                else if (numero_JM >= 3.0 && numero_JM < 4.0)
                    Console.WriteLine("3");
                else if (numero_JM >= 4.0 && numero_JM < 5.0)
                    Console.WriteLine("4");
                else if (numero_JM >= 5.0 && numero_JM < 6.0)
                    Console.WriteLine("5");
                else
                    Console.WriteLine("DEU BRONCA.");

                Console.WriteLine("\n\nPrima return para continuar");
                Console.ReadKey();
            }

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXX slide 15 - Estruturas de Repetição - do/while");
            Console.WriteLine("Usamos quando a execução do bloco" +
            "\n depende de uma condição, mas deve ser " +
            "\n sempre executado pelo menos uma vez");

            i = 0;
            do
            {
                Console.Write(" {0}-", i);
                i++;
            } while (i < 20);

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            do
            {
                Console.WriteLine("\nDigite um número de 1 a 5: ");
                stringTmp_JM = Console.ReadLine();
                numero_JM = double.Parse(stringTmp_JM);

                if (numero_JM >= 0.0 && numero_JM < 1.0)
                    Console.WriteLine("0");
                else if (numero_JM >= 1.0 && numero_JM < 2.0)
                    Console.WriteLine("1");
                else if (numero_JM >= 2.0 && numero_JM < 3.0)
                    Console.WriteLine("2");
                else if (numero_JM >= 3.0 && numero_JM < 4.0)
                    Console.WriteLine("3");
                else if (numero_JM >= 4.0 && numero_JM < 5.0)
                    Console.WriteLine("4");
                else if (numero_JM >= 5.0 && numero_JM < 6.0)
                    Console.WriteLine("5");
                else
                    Console.WriteLine("DEU BRONCA.");

            } while (numero_JM >= 0 && numero_JM < 6);

            Console.WriteLine("\n\nPrima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXX slide 15 - Estruturas de Repetição - while");
            Console.WriteLine("Usamos quando a execução do bloco" +
            "\n depende de uma condição e " +
            "\n pode nunca ser executado");
            i = 0;
            while (i < 30)
            {
                Console.Write(" {0}-", i);
                i++;
            }
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nDigite um número de 1 a 5: ");
            stringTmp_JM = Console.ReadLine();
            numero_JM = double.Parse(stringTmp_JM);
            while (numero_JM < 0 || numero_JM >= 6)
            {
                if (numero_JM >= 0.0 && numero_JM < 1.0)
                    Console.WriteLine("0");
                else if (numero_JM >= 1.0 && numero_JM < 2.0)
                    Console.WriteLine("1");
                else if (numero_JM >= 2.0 && numero_JM < 3.0)
                    Console.WriteLine("2");
                else if (numero_JM >= 3.0 && numero_JM < 4.0)
                    Console.WriteLine("3");
                else if (numero_JM >= 4.0 && numero_JM < 5.0)
                    Console.WriteLine("4");
                else if (numero_JM >= 5.0 && numero_JM < 6.0)
                    Console.WriteLine("5");
                else
                    Console.WriteLine("DEU BRONCA.");

                Console.WriteLine("\nDigite um número de 1 a 5: ");
                stringTmp_JM = Console.ReadLine();
                numero_JM = double.Parse(stringTmp_JM);
            }

            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 16 - Arrays - " +
            "Uni e Multidimensionais");
            Console.WriteLine("Unidimensionais");
            double[] valores = new double[5];
            valores[2] = 5.0;
            Console.WriteLine("3º elemento do array = " + valores[2]);
            Console.WriteLine("Multidimensionais");
            int[,] valores1 = new int[10, 4];
            valores1[2, 3] = 23;
            Console.WriteLine("Elemento na posição [2,3] = " + valores1[2,
            3]);
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 16 - Arrays - " +
            "Tabelas de Tabelas");
            byte[][] vals2 = new byte[5][];
            vals2[1] = new byte[5];
            vals2[2] = new byte[10];
            vals2[1][0] = 10;
            vals2[1][3] = 13;
            Console.WriteLine(vals2[1][0]);
            Console.WriteLine(vals2[1][3]);
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXX - slide 15 - Arrays - Multidimensionais"
            + "versus Tabelas de Tabelas" +
            "\n\n As tabelas multidimensionais são mais " +
            "eficientes em termos de rapidez de iteração" +
            "\n\nAs tabelas de tabelas são mais " +
            "eficientes em termos de ocupação de memória" +
            "\n\nQuando a principal preocupação é rapidez devemos " +
            "optar pelas tabelas multidimensionais" +
            "\n\nQuando a principal preocupação é economizar memória " +
            "devemos optar pelas tabelas de tabelas.");
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX slide 15 - enunms");

            Season0 estação0 = Season0.Fall;
            Console.WriteLine(estação0); // escreve ‘Fall’
            Console.WriteLine((int)estação0); // escreve ‘2’
            Season1 estação1 = Season1.Fall;

            Console.WriteLine(estação1); // escreve ‘Fall’
            Console.WriteLine((int)estação1); // escreve ‘5’

            Season2 estação2 = Season2.Autumn;
            Console.WriteLine(estação2); // escreve ‘Autumn’
            Console.WriteLine((int)estação2); // escreve ‘2’

            Season3 estação3 = Season3.Fall;
            Console.WriteLine(estação3); // escreve ‘Fall’
            Console.WriteLine((int)estação3); // escreve ‘5’
            Console.WriteLine("\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX INVOCAÇÃO de MÉTODOS sem PARÂMETROS" +
                "\n... e sem retorno");
            for (int j = 0; j < 5; j++)
                imprimeParteInteira();
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX INVOCAÇÃO de MÉTODOS COM PARÂMETROS" +
                "\n ... e sem retorno");
            do
            {
                Console.Write("\nEscreva um valor de 1 a 5 >");
                stringTmp_JM = Console.ReadLine();
                imprimeParteInteiraDoParametro(stringTmp_JM);
                numero_JM = double.Parse(stringTmp_JM);
            } while (numero_JM > 0 && numero_JM < 6.0);
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXX INVOCAÇÃO de MÉTODOS COM PARÂMETROS" +
                "\n ... e COM retorno");
            do
            {
                Console.Write("\nEscreva um valor de 1 a 5 > ");
                stringTmp_JM = Console.ReadLine();
                numero_JM = retornaParteInteiraDoParametro(stringTmp_JM);
                Console.WriteLine(numero_JM);
            } while (numero_JM > 0 && numero_JM < 6.0);
            Console.WriteLine("\n\nprima return para continuar");
            Console.ReadKey();

        }

        // void significa que o método não retorna nada,
        // ou, por outras palavras, não inclui nenhuma
        // instrução com return
        // a lista de parâmetros vazia,
        //ou, por outras palavras, as chavetas vazias
        // significam que o método não aceita parâmetros
        static void imprimeParteInteira()
        {
            Console.Write("\nEscreva um valor de 1 a 5 >");
            String stringTmp_JM = Console.ReadLine();
            double numero_JM = double.Parse(stringTmp_JM);
            Console.WriteLine(numero_JM);

            if (numero_JM >= 0.0 && numero_JM < 1.0)
                Console.WriteLine("0");
            else if (numero_JM >= 1.0 && numero_JM < 2.0)
                Console.WriteLine("1");
            else if (numero_JM >= 2.0 && numero_JM < 3.0)
                Console.WriteLine("2");
            else if (numero_JM >= 3.0 && numero_JM < 4.0)
                Console.WriteLine("3");
            else if (numero_JM >= 4.0 && numero_JM < 5.0)
                Console.WriteLine("4");
            else if (numero_JM >= 5.0 && numero_JM < 6.0)
                Console.WriteLine("5");
            else
                Console.WriteLine("DEU BRONCA");
        }

        //A lista de parâmetros com um único identificador,
        //indica que o método deve ser invocado com um único
        //valor ou variável do mesmo tipo do parâmetro
        static void imprimeParteInteiraDoParametro(String parametro)
        {
            double numero_JM = double.Parse(parametro);
            Console.WriteLine(numero_JM);
            if (numero_JM >= 0.0 && numero_JM < 1.0)
                Console.WriteLine("0");
            else if (numero_JM >= 1.0 && numero_JM < 2.0)
                Console.WriteLine("1");
            else if (numero_JM >= 2.0 && numero_JM < 3.0)
                Console.WriteLine("2");
            else if (numero_JM >= 3.0 && numero_JM < 4.0)
                Console.WriteLine("3");
            else if (numero_JM >= 4.0 && numero_JM < 5.0)
                Console.WriteLine("4");
            else if (numero_JM >= 5.0 && numero_JM < 6.0)
                Console.WriteLine("5");
            else
                Console.WriteLine("DEU BRONCA");
        }

        //a declaração do tipo int que antecede
        //o identificador do método indica que o método
        //deve retornar um valor do tipo int
        static int retornaParteInteiraDoParametro(String parametro)
        {
            double numero_JM = double.Parse(parametro);
            if (numero_JM >= 0.0 && numero_JM < 1.0)
                return 0;
            if (numero_JM >= 1.0 && numero_JM < 2.0)
                return 1;
            if (numero_JM >= 2.0 && numero_JM < 3.0)
                return 2;
            if (numero_JM >= 3.0 && numero_JM < 4.0)
                return 3;
            if (numero_JM >= 4.0 && numero_JM < 5.0)
                return 4;
            if (numero_JM >= 5.0 && numero_JM < 6.0)
                return 5;
            // -1 funciona como um retorno de um código de erro
            //depois de darmos excepções deixaremos de usar
            // códigos de erro
            return -1;
        }
    }
}
