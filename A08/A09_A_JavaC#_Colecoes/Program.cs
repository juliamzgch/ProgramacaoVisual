using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP10_Slides_NA
{
    internal class Program
    {

        // Só usamos arrays em duas situações:
        // necessitamos de ainda maior rapidez
        // ou necessitamos de ainda menos espaço ocupado
        // notem que atualmente as ArrayList do java e do C# são "quase"
        // tão eficientes como os arrays em termos de rapidez

        // só na fase de prototipagem rápida é usamos arrays
        // // de dezenas ou centenas  de elementos
        // no mundo real as coleções têm centenas de milhar, milhões
        // ou centenas de milhões de elementos ... por baixo
        // da´a necessida de optimizar o desempenho da gestão de arrays

        

        // As coleções são REGRA GERAL privadas!!!
        // nunca são passadas para o exterior da classe
        // são fornecidos métodos na classe para
        // inserir, remover, aceder a um elemento do array
        // por forma a manter a integridade da informação
        private static Aluno_NA[] alunos_NA = new Aluno_NA[3];

        // Para gerir um array NECESSITAMOS De uma variável
        private static int numeroDePosicoesOcupadas = 0;

        // o método AddElemento(<T> elemento)
        // REGRA 1: Novos elementos são ADICIONADOS ao array
        // na primeira posição LIVRE
        public static void addAluno (Aluno_NA aluno_NA)
        {
            if (numeroDePosicoesOcupadas < alunos_NA.Length)
            {
                alunos_NA[numeroDePosicoesOcupadas] = aluno_NA;
                numeroDePosicoesOcupadas++;
            }
            else
            {
                // normalmente duplicamos o tamanho do array
                // mas se o arrays crescer muito depressa
                // podemos quadruplicar/decuplicar
                Aluno_NA[] tmp = new Aluno_NA[alunos_NA.Length*2];
                for (int i = 0; i < numeroDePosicoesOcupadas; i++)
                {
                    tmp[i] = alunos_NA[i];
                }
                alunos_NA = tmp;
                alunos_NA[numeroDePosicoesOcupadas] = aluno_NA;
                numeroDePosicoesOcupadas++;

            }

        }


        public static void removeAt(int index)
        {
            
                for (int i = index; i < numeroDePosicoesOcupadas-1; i++)
                {
                    alunos_NA[i] = alunos_NA[i + 1];
                }
                numeroDePosicoesOcupadas--;
           
        }

        static void Main(string[] args)
        {

            addAluno(new Aluno_NA() { Nome_NA = "A", Numero_NA = "1" });
            addAluno(new Aluno_NA() { Nome_NA = "B", Numero_NA = "2" });
            addAluno(new Aluno_NA() { Nome_NA = "C", Numero_NA = "3" });
            //addAluno(new Aluno_NA() { Nome_NA = "D", Numero_NA = "4" });


            for (int i=0; i<numeroDePosicoesOcupadas; i++)
            {
                Console.WriteLine(alunos_NA[i]);
            }

            Console.WriteLine();

            removeAt(2);
            for (int i = 0; i < numeroDePosicoesOcupadas; i++)
            {
                Console.WriteLine(alunos_NA[i]);
            }

            Console.ReadKey();











            //// ESTOU A USAR O CONSTRUTOR SEM PARAMETROS
            //// OFERECIDO PELO C# ;-)
            //var aluno1 = new Aluno_NA()
            //{
            //    Nome_NA = "Tomás",
            //    Numero_NA = "2022001123"
            //};// a instrução acaba no ;

            //Console.WriteLine("XXXXXX Slide 6");
            //// UMA Lista (List<T>)
            //// É um tipo genérico (que pode ser parametrizado
            //// para guardar elementos do tipo que especificarmos
            //// Pode ter elementos repetidos
            //// è indexada: cada elemento tem o seu indice [i]
            //List<String> nomes; // declaração da variável nomes que é uma List de strings
            //nomes = new List<String>(); // LEMBREM_SE QUE TÊM SEMPRE DE CRIAR A LISTA
            //// Antes de lhe adicionarem elementos
            //Console.WriteLine("Lista de Nomes");
            //nomes.Add("Alberto");
            //nomes.Add("Bernardo");
            //nomes.Add("Celeste");
            //nomes.Add("Dulce");
            //foreach (String nome in nomes)
            //  Console.WriteLine(nome.ToString());
            //nomes[2] = "Carlos";
            //Console.WriteLine(nomes[2]);
            //Console.WriteLine(nomes.Capacity);
            //Console.WriteLine(nomes.Count);

            //Console.WriteLine("XXXXXX Slide 7 : List<Aluno>");
            //Alunos_NA alunos = new Alunos_NA();
            //alunos.Add(aluno1);
            //// estou a usar a criação de objetos com inicialização de propriedades
            //alunos.Add(new Aluno_NA() { Nome_NA = "Armando Albino", Numero_NA = "190210001" });
            //alunos.Add(new Aluno_NA() { Nome_NA = "Armando Albino", Numero_NA = "190210002" });
            //alunos.Add(new Aluno_NA() { Nome_NA = "Beatriz Batarda", Numero_NA = "190210003" });
            //alunos.Add(new Aluno_NA() { Nome_NA = "Carlos Candeias", Numero_NA = "190210004" });

            //Console.WriteLine(alunos.ToString());

            //Console.WriteLine("XXXXXX Slide 9 : Turma tem (é composta por) uma lista de alunos");
            //Turma_NA turma = new Turma_NA("CTESP TPSI", 2022, "Barreiro");
            //turma.Add(new Aluno_NA() { Nome_NA = "Armando A.", Numero_NA = "190210001" });
            //turma.Add(new Aluno_NA() { Nome_NA = "Armando B.", Numero_NA = "190210002" });
            //turma.Add(new Aluno_NA() { Nome_NA = "Beatriz B.", Numero_NA = "190210003" });
            //turma.Add(new Aluno_NA() { Nome_NA = "Carlos C.", Numero_NA = "190210004" });

            //Console.WriteLine(turma.ToString());

            //Console.WriteLine("XXXXXX Slide 10 : HashSet < T >");
            //// Um conjunto (SET) é uma coleção que mimetiza a noção de conjunto da matemática
            //// 1. Um conjunto (Set<T>) NÂO TEM elementos repetidos
            //// 2. Não existe o conceito de ordem para os elementos
            //// (OU seja) não podemos assumir que os elemento estão ordenados pela ordem de adição
            //// 3. Os elementos não são acessíveis por um indice
            //// (ou seja) Não existe um indice para aceder aos elementos
            //HashSet<String> numeros = new HashSet<String>();
            //numeros.Add("19021001");
            //numeros.Add("19021002");
            //numeros.Add("19021003");
            //numeros.Add("19021004");
            //numeros.Add("19021003");// Não insere! porque é repetido
            //numeros.Add("19021004");// não insere porque já existe um igual ...
            //foreach(String numero in numeros)
            //    Console.WriteLine(numero);
            //// a classe HashSet<STring> deteta strings iguais porque a classe
            //// String já possui os métodos getHashCode e Equals

            //// VAMOS VER A QUESTÂO DA IGUALDADE DE OBJETOS:
            //Aluno_NA a1 = new Aluno_NA() { Nome_NA = "Armando Albino", Numero_NA = "190210001" };
            //Aluno_NA a2 = new Aluno_NA() { Nome_NA = "Armando Albino", Numero_NA = "190210001" };
            //Console.WriteLine(a1==a2);
            //// o Equals (==) de objet compara os endereços de memória das referencias
            //a2 = a1;
            //Console.WriteLine(a1 == a2);

            List<Aluno_NA> als = new List<Aluno_NA> {
                new Aluno_NA() {Nome_NA = "Jose Antunes", Numero_NA = "2345"},
                new Aluno_NA() {Nome_NA = "Ana Costa", Numero_NA = "4567"},
                new Aluno_NA() {Nome_NA = "Manuel Jose", Numero_NA = "6789"},
            };

            Console.WriteLine("\n\nALUNOS com o nome 'Jose':");

            var res = from a in als where a.Nome_NA.Contains("Jose") select a.Nome_NA;

            foreach (var a in res)
                Console.WriteLine("> " + a);

            var resPD = from a 
                        in als 
                        where a.Nome_NA.Contains("Jose") 
                        select new { Nome = a.Nome_NA };

            foreach (var a in resPD)
                Console.WriteLine("> " + a);
        }
    }

}
