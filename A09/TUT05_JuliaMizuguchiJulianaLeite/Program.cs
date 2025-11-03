namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** 2 Listas - List<T>" +
                "\n*** Listas são coleções de elementos indexados" +
                "\n***        e possivelmente repetidos" +
                "\n*** Abordaremos apenas as listas parametrizadas" +
                "\n*** List<T> onde T é o tipo de dados passível" +
                "\n*** de armazenar na lista\n");
            // Declaração de uma lista de inteiros
            List<int> listaDeInteiros;
            // Criação da lista (ou inicialização da variável
            listaDeInteiros = new List<int>();
            // Inicialização dos elementos da lista
            for (int i = 0; i < 10; i++)
                listaDeInteiros.Add(i);
            foreach (int i in listaDeInteiros)
                Console.Write(i + " - ");

            int soma = 0;
            foreach (int i in listaDeInteiros)
                soma += i;

            Console.WriteLine("\n\nSoma: " + soma + "\n");

            for (int i = 0; i < 5; i++)
                Console.Write(listaDeInteiros[i] + " - ");

            Console.WriteLine("\n\nXXXXXXXXXXXXXXX 3.1 CLASSES");

            CartaoDoCidadao_JMJL cartao1_JMJL = new CartaoDoCidadao_JMJL("12345678", new DateTime(2028, 5, 31));

            Console.WriteLine("\n" + cartao1_JMJL);

            Console.WriteLine("\nXXXXXXXXXXX 3.2 COMPOSIÇÃO");

            Pessoa_JMJL pessoa1_JMJL = new Pessoa_JMJL("Urdegunda Perenes", new DateTime(1995, 8, 15), cartao1_JMJL);
            Pessoa_JMJL pessoa2_JMJL = new Pessoa_JMJL("Mendez Leão Silva", new DateTime(1999, 4, 10), new CartaoDoCidadao_JMJL("22222222", new DateTime(2021, 1, 1)));

            Console.WriteLine("\n" + pessoa1_JMJL);
            Console.WriteLine("\n" + pessoa2_JMJL);

            Console.WriteLine("\nXXXXXXXXXXXXXX 3.3 HERANÇA");

            Aluno_JMJL aluno1_JMJL = new Aluno_JMJL("Bergomano Bielogrundo", new DateTime(2002, 3, 4), new CartaoDoCidadao_JMJL("33333333", new DateTime(2022, 2, 28)), "72261171");
            Aluno_JMJL aluno2_JMJL = new Aluno_JMJL("Anelise Detroine", new DateTime(2008, 6, 25), new CartaoDoCidadao_JMJL("4444444", new DateTime(2021, 7, 30)), "72334471");

            Console.WriteLine("\n" + aluno1_JMJL);
            Console.WriteLine("\n" + aluno2_JMJL);

            Console.WriteLine("\nXXXXXXXXXXXXXXX 4.1 COLEÇÕES =>  List<T>");
            List<Pessoa_JMJL> pessoas_JMJL = new List<Pessoa_JMJL>();
            pessoas_JMJL.Add(pessoa1_JMJL);
            pessoas_JMJL.Add(pessoa2_JMJL);
            pessoas_JMJL.Add(aluno1_JMJL);
            pessoas_JMJL.Add(aluno2_JMJL);
            foreach (Pessoa_JMJL p in pessoas_JMJL)
                Console.WriteLine(p);

            Console.WriteLine("\nXXXXXXXXXXXXXXX COLEÇÕES COMPOSTAS POR LISTAS");
            Turma_JMJL turmaB_JMJL = new Turma_JMJL("CTESP-TPSI", 2, 'A');
            turmaB_JMJL.AddAluno_JMJL(aluno1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(aluno2_JMJL);
            turmaB_JMJL.AddAluno_JMJL(aluno1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(aluno2_JMJL);
            turmaB_JMJL.AddAluno_JMJL(aluno1_JMJL);
            turmaB_JMJL.AddAluno_JMJL(aluno2_JMJL);
            Console.WriteLine(turmaB_JMJL);
            turmaB_JMJL.RemoveAluno_JMJL(aluno1_JMJL); // remove o 1º aluno1_JMJL encontrado
            turmaB_JMJL.RemoveAt_JMJL(turmaB_JMJL.GetLegth_JMJL() - 1);
            Console.WriteLine("\nXXXX Removeu: \n" + turmaB_JMJL);

            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXXXXXX" +
                "XXX Consolidação de classes compostas por listas ");
            Livraria_JMJL livraria_JMJL = new Livraria_JMJL("Livraria do Povo", "123456789", "www.livrariadopovo.pt");
            Livro_JMJL livro1_JMJL = new Livro_JMJL("Aprender C# em 21 dias", "LPOO1234", new Autor_JMJL("João Silva", "PT-BR"), 390);
            Livro_JMJL livro2_JMJL = new Livro_JMJL("Programação Avançada em C#", "LPOO5678", new Autor_JMJL("Maria Oliveira", "PT-PT"), 275);
            livraria_JMJL.AddLivro_JMJL(livro1_JMJL);
            livraria_JMJL.AddLivro_JMJL(livro2_JMJL);
            Console.WriteLine("\n" + livraria_JMJL);

            Console.WriteLine("\nXXXXXXXXXX COLEÇÕES QUE HERDAM DE List<T>");
            Pessoas_JMJL listaDePessoas_JMJL = new Pessoas_JMJL();
            listaDePessoas_JMJL.Add(pessoa1_JMJL);
            listaDePessoas_JMJL.Add(pessoa2_JMJL);
            listaDePessoas_JMJL.Add(aluno1_JMJL);
            listaDePessoas_JMJL.Add(aluno2_JMJL);
            listaDePessoas_JMJL.Add(pessoa1_JMJL);
            listaDePessoas_JMJL.Add(pessoa2_JMJL);
            listaDePessoas_JMJL.Add(aluno1_JMJL);
            listaDePessoas_JMJL.Add(aluno2_JMJL);
            Console.WriteLine(listaDePessoas_JMJL);
            listaDePessoas_JMJL.Remove(pessoa1_JMJL); // remove a 1ª pessoa1_JMJL encontrada
            listaDePessoas_JMJL.RemoveAt(listaDePessoas_JMJL.Count - 1);
            Console.WriteLine("\nXXXX Removeu: \n" + listaDePessoas_JMJL);

            Console.WriteLine("\n******************* 5 Conjuntos -  HashSet<T>" +
                "\n*** Conjuntos são coleções de elementos:" +
                "\n***           sem ordem nem repetições." +
                "\n*** Significando isto que:" +
                "\n*** 1) não podemos assumir que os elemntos estão" +
                "\n***    de alguma forma ordenados pelo que também" +
                "\n***    não podemos aceder-lhes através de um indíce" +
                "\n*** 2) não podemos inserir/adicionar elementos" +
                "\n***    repetidos a um conjunto, cabendo ao progrmador" +
                "\n***    definir o que são dois elementos iguais," +
                "\n***    implementando os métodos" +
                "\n***    Equals() e" +
                "\n***    GetHashCode()" +
                "\n***    nas classes que o requeiram");

            Console.WriteLine("\n******************* 5.1 HashSet<String>");
            // Declaração de uma variável do tipo HashSet de strings
            HashSet<String> nomesDePessoas_JMJL;
            // Criação de um objeto do tipo HashSet de strings
            // atribuição do objeto à variável
            nomesDePessoas_JMJL = new HashSet<String>();
            // inicialização do conjunto com nomes repetidos
            nomesDePessoas_JMJL.Add("Ibn Kasi");
            nomesDePessoas_JMJL.Add("Geraldo sem Pavor");
            nomesDePessoas_JMJL.Add("Ibn Kasi");
            nomesDePessoas_JMJL.Add("Dona Berengária");
            foreach (String s in nomesDePessoas_JMJL)
                { Console.WriteLine(s); }
            nomesDePessoas_JMJL.Remove("Dona Berengária");
            nomesDePessoas_JMJL.Add("Dona Sancha");
            Console.WriteLine("\nDepois da remoção e adição: ");
            foreach (String s in nomesDePessoas_JMJL)
                { Console.WriteLine(s); }

            HashSet<int> conjuntoDeNumeros_JMJL = new HashSet<int>();
            conjuntoDeNumeros_JMJL.Add(10);
            conjuntoDeNumeros_JMJL.Add(11);
            conjuntoDeNumeros_JMJL.Add(11); // repetido e não adicionado
            conjuntoDeNumeros_JMJL.Add(12);
            conjuntoDeNumeros_JMJL.Add(20);
            conjuntoDeNumeros_JMJL.Add(21);
            conjuntoDeNumeros_JMJL.Add(22);
            conjuntoDeNumeros_JMJL.Add(22); // repetido e não adicionado
            // o 11 e o 22 repetidos não vão aparecer
            // pois não chegaram nem a ser adicionados ao conjunto
            Console.WriteLine("\nHashSet de inteiros");
            foreach (int n in conjuntoDeNumeros_JMJL)
                { Console.WriteLine(n); }

            Console.WriteLine("\n** 5.2 Classe com conjunto de ALuno_JMJL");

            TurmaComConjunto_JMJL turmaComConjunto_JMJL;
            turmaComConjunto_JMJL = new TurmaComConjunto_JMJL("TPSI", 1, 'B');
            turmaComConjunto_JMJL.AddAluno_JMJL(aluno1_JMJL);
            turmaComConjunto_JMJL.AddAluno_JMJL(aluno2_JMJL);
            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Siznanda Simeão",
                                                               new DateTime(1141, 2, 23),
                                                               new CartaoDoCidadao_JMJL("1239876",
                                                                                        new DateTime(1150, 12, 25)),
                                                                "2025123123"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Siznando Simeão",
                                                               new DateTime(1141, 2, 23),
                                                               new CartaoDoCidadao_JMJL("1239876",
                                                                                        new DateTime(1150, 12, 25)),
                                                                "2025123123"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Sezimanda Simão",
                                                               new DateTime(1140, 3, 24),
                                                               new CartaoDoCidadao_JMJL("98764321",
                                                                                        new DateTime(1151, 12, 25)),
                                                                "2025123124"));

            turmaComConjunto_JMJL.AddAluno_JMJL(new Aluno_JMJL("Sezimando Simão",
                                                               new DateTime(1140, 3, 24),
                                                               new CartaoDoCidadao_JMJL("98764321",
                                                                                        new DateTime(1151, 12, 25)),
                                                                "2025123124"));

            // Note que pudemos adicionar objetos com os mesmos valores nos campos
            // CartaoDoCidadao_JMJL e Numero_JMJL porque, obviamente o C# não pode saber 
            // o que é que nós programadores consideramos "dois alunos iguais"
            // temos assim que definir o que são dois alunos iguais:
            // Vamos considerar que dois alunos são iguais se os seus números
            // de aluno forem iguais e assim sendo, vamos definir
            // os métodos Equals e GetHashCode na classe Aluno_JMJL
            Console.WriteLine(turmaComConjunto_JMJL);


            Console.WriteLine("\n******************* 6 Tabelas - Dictionary<K,V>" +
                "\n*** Tabelas são coleções de pares" +
                "\n***         chave (Key, K) - valor (Value, V):" +
                "\n*** Significando isto que:" +
                "\n*** 1) Uma tabela não pode ter chaves repetidas" +
                "\n*** 2) Mas pode ter valores repetidos" +
                "\n*** 3) Entenda-se o conceito de chaves iguais" +
                "\n***    tal como o dos elementos iguais para os " +
                "\n***    conjuntos anteriormente abordados" +
                "\n*** 4) É fácil reconhecer nos Dictionary o" +
                "\n***    equivalente aos Map<K,V> do Java");

            // Declaração da tabela
            Dictionary<Aluno_JMJL, int> notasDePv_JMJL;
            // Criação da tabela
            notasDePv_JMJL = new Dictionary<Aluno_JMJL, int>();
            // Inicialização de pares <chave, valor>
            notasDePv_JMJL.TryAdd(aluno1_JMJL, 10);
            notasDePv_JMJL.TryAdd(aluno1_JMJL, 15);
            notasDePv_JMJL.TryAdd(aluno2_JMJL, 10);
            notasDePv_JMJL.TryAdd(new Aluno_JMJL("Siznanda Simeão", 
                                    new DateTime(1141, 2, 23),
                                     new CartaoDoCidadao_JMJL("1239876",
                                                             new DateTime(1150, 12, 25)),
                                   "2025123123"), 10);
            notasDePv_JMJL.TryAdd(new Aluno_JMJL("Siznando Simeão",
                                    new DateTime(1141, 2, 23),
                                     new CartaoDoCidadao_JMJL("1239876",
                                                             new DateTime(1150, 12, 25)),
                                   "2025123123"), 10);

            // alteração da nota do aluno 1
            notasDePv_JMJL[aluno1_JMJL] = 14;
            Aluno_JMJL? alunoEncontrado_JMJL = null;

            // iteração pelas chaves
            foreach (Aluno_JMJL a in notasDePv_JMJL.Keys)
            {
                if (a.NumeroDeAluno_JMJL.Equals("2025123123"))
                    alunoEncontrado_JMJL = a;
            }
            notasDePv_JMJL[alunoEncontrado_JMJL] = 15;

            // iteração pelos valores
            foreach (int i in notasDePv_JMJL.Values)
            {
                Console.WriteLine(i);
            }

            foreach (KeyValuePair<Aluno_JMJL, int> kv in notasDePv_JMJL)
            {
                Console.WriteLine(kv.Value + " - " + kv.Key);
            }
        }
    }
}
