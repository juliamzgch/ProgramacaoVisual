using System;
using System.Linq;
using System.Collections.Generic;

namespace TP06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

           
            // Como Alunos é uma List<Aluno> 
            // 1. Tem já todos os métodos de List<T>
            // 2. Só temos de codificar o ToString caso necessitemos dele
            Alunos alunos = new Alunos();
            Console.WriteLine("A Lista Alunos : List<Aluno>");

            alunos.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            alunos.Add(new Aluno() { Nome = "Armando Albino", Numero = "190210010" });
            alunos.Add(new Aluno() { Nome = "Beatriz Martins", Numero = "190210011" });
            alunos.Add(new Aluno() { Nome = "Carlos Brotas", Numero = "190210012" });

            Console.WriteLine("A Lista Alunos com quatro alunos");
            Console.WriteLine(alunos.ToString());
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 4 - LinQ");
            // A. Simplifica e uniformiza a forma de obter informação 
            // a partir de um QUALQUER conjunto de dados. 
            // B. O conjunto de dados pode ser qualquer coleção : um array, 
            // uma lista ou uma base de dados. 
            // A sintaxe mais simples de uma instrução LINQ é:
            // from iterador in coleção select elementoSeleccionado

            // A Utilização do LinQ faz-se me dois passos
            // 1. definimos a query
            IEnumerable<Aluno> tudoNaLista = from aluno in alunos select aluno;
            // 2. executamos a query
            var colecao = tudoNaLista;
            // ou 2.
            foreach (Aluno a in tudoNaLista)
                Console.WriteLine(a);
            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 5 - LinQ query");
            //Dada uma coleção:
            int[] nums = new int[] { 1, 2, 4, 7, 12, 14, 15, 16, 18, 21 };

            var res = from i
                      in nums
                      where i >= 5 &&
                            i <= 15
                      select i;

            foreach (int x in res)
                Console.WriteLine("> " + x);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 6 - LinQ Execução Diferida");
            // A query LINQ é executada no momento em que é invocada 
            // e assim o resultado traz sempre os valores atualizados. 

            // vamos adicionar dois novos alunos à nossa coleção de alunos
            alunos.Add(new Aluno() { Numero = "190210015", Nome = "Gabriel Fagundes" });
            alunos.Add(new Aluno() { Numero = "190210016", Nome = "Hedmundo Pedro" });

            // quando agora executarmos a query definida acima
            // no slide 22
            // ela retorna já os dois alunos entretanto adicionados
            foreach (Aluno a in tudoNaLista)
                Console.WriteLine(a);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 7 - LinQ Execução Imediata");
            // Por vezes interessa-nos ficar com uma "fotografia"
            // da coleção num dado momento (para futura comparação por exemplo)
            // Nesse casos podemos guardar o resultado da query numa coleção:
            // expressão LINQ com execução imediata
            List<String> joses =
                 (from a
                 in alunos
                 where a.Nome.Contains("Fagundes")
                 select a.Nome).ToList();

            Console.WriteLine("\n\nALUNOS com 'Fagundes' no nome (3):");
            foreach (String n in joses)
                Console.WriteLine("> " + n);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 8 e 9  - Operadores");
            Console.WriteLine("Experimente usar os operadores");
            Console.WriteLine("orderby , ascending e descending");
            Console.WriteLine(" ToList<>() converte o resultado numa lista de elementos");
            Console.WriteLine(" ToArray<>() converte o resultado num array de elementos");
            Console.WriteLine(" Reverse<>() inverte a ordem dos elementos, etc.");
            Console.WriteLine(" Distinct<>(), Union<>(),Intersect<>()");
            Console.WriteLine(" ou outros que agregam os resultados");
            Console.WriteLine(" Count<>(), Sum<>(), Min<>(), Max<>(), etc. ");

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 10  - Projecção de dados com tipos anónimos");
            // É possível obter como resultado de uma query LINQ 
            // um conjunto de dados de um tipo anónimo.
            // Tal pode ser  útil quando se pretende 
            // analisar um subconjunto da informação existente nos dados.
            // No exemplo foi criado um tipo anónimo com os campos Nome e NumeroDeAlunos 
            // que contém apenas a informação do nome e do total de alunos existente na disciplina.
            var fagundes = from d in alunos
                       where d.Nome.Contains("Fagundes")
                       select
                       new { Nome = d.Nome, NumeroDeAlunos = alunos.Count() };
            foreach (var a in fagundes)
                Console.WriteLine("> " + a);

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nXXXXXXXXXXXXXX Slide 13  - Linq C/ Métodos de Extensão");
            // É possível não utilizar a sintaxe integrada do LINQ definida para a linguagem C#. 
            // Neste caso aplicam-se directamente os métodos de extensão sobre as fontes de dados. 
            // Muitos dos métodos de extensão têm como argumento referências 
            // de métodos que são habitualmente chamados para cada elemento do conjunto de dados.
            // Nos exemplos mostra-se a sintaxe LINQ usando os métodos de extensão. 
            // Usam-se expressões lambda para passar os métodos como argumentos
            var res4 = alunos.Where
                       (a => a.Nome.Contains("Fagundes")).Select
                       (a => a.Nome);
            Console.WriteLine("alunos.Where (a => a.Nome.Contains(\"Fagundes\")).Select (a => a.Nome);");
            foreach (var a in res4.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine("alunos.OrderBy (a => a.Nome).Select(a => a);");
            var res5 = alunos.OrderByDescending
                       (a => a.Nome).Select(a => a);
            foreach (var a in res5.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine(" alunos.Where (a => a.Numero.Contains(\"11\")).Select (a => a.Nome);");
            var res6 = alunos.Where (a => a.Numero.Contains("11")).Select (a => a.Nome);
            foreach (var a in res6.ToList()) Console.WriteLine(a.ToString());
            Console.WriteLine();

            Console.WriteLine("Prima uma tecla para continuar");
            Console.ReadKey();
        }
    }
}
