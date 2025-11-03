namespace A08_SlidesResumo_JM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXX LISTAS -> List<T>" +
                        "\n XXX Listas são tipos genéricos porque" +
                        "\n XXX tem de ser parametrizados para um Tipo De Dados" +
                        "\n XXX São coleções de elementos ordenados (pela ordem de adição)" +
                        "\n XXX Com repetições" +
                        "\n XXX Como são ordenados... são indexados ie. cada elemento" +
                        "\n XXX tem o seu indíce (a sua posição na lista)");

            // declaramos variáveis do tipo Lista de qualquer coisa -> List<T>
            List<Aluno> alunos;
            // e atribuimos o objeto criado à variável declarada
            alunos = new List<Aluno>();

            Aluno al1 = new Aluno()
            {
                Nome = "Grenomilde de Aragão",
                Numero = "001"
            };

            Aluno al2 = new Aluno()
            {
                Nome = "Mendez ibn Massud",
                Numero = "002"
            };

            Aluno al3 = new Aluno()
            {
                Nome = "Grenomilde de Aragão",
                Numero = "001"
            };

            Aluno al4 = al3;

            alunos.Add(al1);
            alunos.Add(al2);
            alunos.Add(al3);
            alunos.Add(al4);

            for (int i = 0; i < alunos.Count; i++)
                Console.WriteLine(alunos[i]);

            Console.WriteLine("\nXXXXXX Classes compostas por listas");
            al1.Add(new Nota()
            {
                Cadeira = "ProgVis",
                Valor = 15
            });

            al1.Add(new Nota()
            {
                Cadeira = "ProgMov",
                Valor = 16
            });

            al1.Add(new Nota()
            {
                Cadeira = "ProInSe",
                Valor = 12
            });

            foreach (Aluno a in alunos)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nXXXXXX Classes que herdam de listas");

            Turma turmaCtesp = new Turma();
            turmaCtesp.Add(al1);
            turmaCtesp.Add(al2);
            turmaCtesp.Add(al3);
            turmaCtesp.Add(al4);
            // é interessante quando uma classe herda de List<T>
            // porque podemos usar todos os métodos da List<T>
            Console.WriteLine(turmaCtesp);

            Console.WriteLine("\nXXXXXXXXXX CONJUNTOS: HashSet<T>" +
                "\n XXX Conjuntos são tipos de dados genéricos que tem" +
                "\n XXX de ser parametrizados com o tipo de dados " +
                "\n XXX que vão integrar." +
                "\n XXX Os conjuntos são coleções de elementos não ordenados" +
                "\n XXX e portanto também não indexados (ie. os elementos não tem" +
                "\n XXX um indíce através do qual possam ser acendidos) e que" +
                "\n XXX NÃO POSSUEM ELEMENTOS REPETIDOS");

            // declaração de uma variável do tipo HashSet<DeQualquerCoisa>
            HashSet<int> numeros;
            // atribuir a números um objeto da classe HashSet<int>
            numeros = new HashSet<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(4); // não dá erro... mas não é adicionado
            // o mesmo acontece para strings

            Console.WriteLine(numeros); // ToString() de Object

            // como os conjuntos não são indexados
            // não posso acender aos seus elementos
            // através de um índice e portanto
            // não posso usar o for para iterar conjuntos
            foreach (int n in numeros)
            {
                Console.WriteLine(n + " - ");
            }

            Console.WriteLine("XXXXX Conjuntos: o que são dois " +
                "\n XXX elementos iguais?" +
                "\n XXX Dois elementos são iguais se o método " +
                "\n XXX boolean Equals(Obj o)" +
                "\n XXX retornar ture ..." +
                "\n XXX O C# já oferece o método Equals para os tipo .NET" +
                "\n XXX Mas para os tipos de dados definidos pelo programador" +
                "\n XXX tem de ser o programador a definit os métodos Equals e" +
                "\n XXX GetHashCode() ... para esse tipo de dados");

            HashSet<Aluno> conjuntoDeALunos = new HashSet<Aluno>();
            // a linguagem percebe que al3 e al4 são iguais
            // porque al4 é uma referência para al3
            // o al3 só é igual para o programador

            conjuntoDeALunos.Add(al1);
            conjuntoDeALunos.Add(al2);
            conjuntoDeALunos.Add(al3);
            conjuntoDeALunos.Add(al4);

            foreach (Aluno a in conjuntoDeALunos)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("XXXXXXXXXXXXXX TABELAS: Dictionary<Key, Value>" +
                "\n XXX Tabelas são coleções de pares <chave, valor> em que" +
                "\n XXX não pode haver chaves repetidas, mas pode haver valores" + // onde o método Equals devolve true" +
                "\n XXX repetidos e os pares estão indexados pela chave");
            // o indice de chave valor é a chave

            // declarar uma tabela de Alunos e nomes
            // o objeto de aluno é a chave
            Dictionary<Aluno, String> nomesDeAlunos;
            // criar o objeto e atribui-lo a variável
            nomesDeAlunos = new Dictionary<Aluno, string>();
            nomesDeAlunos.TryAdd(al1, al1.Nome);
            nomesDeAlunos.TryAdd(al2, al2.Nome);
            nomesDeAlunos.TryAdd(al3, al3.Nome);
            nomesDeAlunos.TryAdd(al4, al4.Nome);
            // para atualizar tabelas em C# ... temos mesmo
            // de remover o elemento
            nomesDeAlunos.Remove(al3);
            // e adcionar o novo par chave-valor
            nomesDeAlunos.TryAdd(al3, "Outro Nome");
            // O TryAdd tenta adicionar
            // se conseguir, tudo bem
            // se não conseguir (chave repetida)
            // ele não adiciona e não dá erro

            Console.WriteLine("XXX ITERAÇÃO DE TABELAS" +
                "\n XXX Eu posso iterar tabelas de 3 formas:" +
                "\n XXX 1. pelas chaves .keys" +
                "\n XXX 2. pelos valores .values" +
                "\n XXX 3. pelos pares chaves valor ... que são de que tipo?");

            Console.WriteLine("\n XXX TABELA iterada pelas chaves");
            foreach (Aluno item in nomesDeAlunos.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n XXX TABELA iterada pelas valores");
            foreach (String item in nomesDeAlunos.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n XXX TABELA iterada pelos pares chave-valor");
            foreach (KeyValuePair<Aluno, String> item in nomesDeAlunos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
