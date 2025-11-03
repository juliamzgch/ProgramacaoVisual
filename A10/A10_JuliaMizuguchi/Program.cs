namespace A10_JuliaMizuguchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n XXXXX 28.10.2025\n");
            Console.WriteLine("\n XXXX EXECUÇÃO IMEDIATA");
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(3);
            nums.Add(5);
            nums.Add(7);

            // a instrução LINQ mais simples
            // from <iterador> in <colecao/BD> select i
            // retorna todos os elementos da colecao
            var resultado = from i
                            in nums
                            select i; // definição da query

            // System.Linq.Enumerable+ArrayWhereIterator`1[System.Int32]
            Console.WriteLine(resultado);

            foreach (int x in resultado) // execução da query
            {
                Console.WriteLine("> " + x);
            }
            Console.WriteLine("\n Após alterar");

            // a execução diferida é standard no LinQ
            // a execução da query/instrução LinQ é diferida
            // pelo que é aplicada a coleção 
            // no momento da execução
            nums.Add(8);

            foreach (int x in resultado) // execução da query
                Console.WriteLine("> " + x);

            int[] nums2 = nums.ToArray();
            var resultado1 = from i in nums2 select i;
            foreach (int x in resultado1) // execução da query
                Console.WriteLine("> " + x);

            nums2[0] = 100;

            foreach (int x in resultado1) // execução da query
                Console.WriteLine("> " + x);

            // podemos forçar a execução imediata usando métodos
            // de extensão, se quisermos uma fotografia de um 
            // momento da coleção
            Console.WriteLine("\n XXXX EXECUÇÃO IMEDIATA");
            List<int> foto = resultado.ToList();
            foreach (int x in foto)
                Console.WriteLine(x);

            foto.Add(1);
            foto.Add(2);

            Console.WriteLine("\n XXXXX PROJEÇÃO DE DADOS");
            // = -> le "torna-se"
            List<Disciplina> disciplinas = new List<Disciplina>();
            disciplinas.Add(new Disciplina()
            {
                Nome = "Programação Visual",
                TotalDeAlunos = 27,
                Curso = "TPSI"
            });
            disciplinas.Add(new Disciplina()
            {
                Nome = "Programação Web",
                TotalDeAlunos = 23,
                Curso = "TPSI"
            });
            disciplinas.Add(new Disciplina()
            {
                Nome = "Gestão",
                TotalDeAlunos = 15,
                Curso = "TPSI"
            });

            // definimos uma query
            // que quando for executada
            // retorna um IEnumerable<T> com os nomes das UC's
            // que contém "Programação"
            var duasColunas = from d in disciplinas
                              where d.Nome.Contains("Programação")
                              select new { NOME_DA_UC = d.Nome };

            int totalDeUcsComProgramacaoNoNome = duasColunas.Count();

            Console.WriteLine(totalDeUcsComProgramacaoNoNome);

            foreach (var nome in duasColunas)
                Console.WriteLine(nome);




        }
    }
}
