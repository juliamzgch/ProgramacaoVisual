using JavaCSharpColecoesResumo;
using System;
// para usar listas
// temos de =>
using System.Collections.Generic;

namespace JavaCSharp_ColecoesResumo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nXXXXXXXXXXXXXXX LISTAS: List<T>");
            Console.WriteLine("XXX Listas são coleções de elementos indexados" +
                "\nXXX com possíveis repetições");

            Aluno al1 = new Aluno(1, "Cide Frederiz");
            Aluno al2 = new Aluno(2, "Martinus ibn Atumad");
            Aluno al3 = new Aluno(3, "Abulfadal Randulfo Soleimanis");

            List<Aluno> lista = new List<Aluno>();
            lista.Add(al1);
            lista.Add(al2);
            lista.Add(al3);
            foreach (Aluno al in lista)
            {
                Console.WriteLine("XXX " + al.ToString());
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX LISTAS: Classes com listas");
            // A classe Aluno é ocmposta por uma lista de Nota
            al1.addNota(new Nota() { UnidadeCurricular = "PV", Avaliacao = 12 });
            al1.addNota(new Nota() { UnidadeCurricular = "MAT1", Avaliacao = 10 });
            al1.addNota(new Nota() { UnidadeCurricular = "PSI", Avaliacao = 15 });
            foreach (Aluno al in lista)
            {
                Console.WriteLine("\n" + al.ToString());
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX CONJUNTOS: HashSet<T>");
            Console.WriteLine("XXX Conjuntos são coleções de elementos" +
                              "\nXXX não indexados e sem repetições");

            HashSet<Nota> notas = new HashSet<Nota>();
            notas.Add(new Nota() { UnidadeCurricular = "AAA", Avaliacao = 10 });
            notas.Add(new Nota() { UnidadeCurricular = "BBB", Avaliacao = 12 });
            notas.Add(new Nota() { UnidadeCurricular = "CCC", Avaliacao = 12 });
            notas.Add(new Nota() { UnidadeCurricular = "CCC", Avaliacao = 12 });// adiciona ou não?
            Nota no1 = new Nota()
            {
                UnidadeCurricular = "DDD",
                Avaliacao = 12
            };
            notas.Add(no1);
            Nota no2 = no1;
            notas.Add(no2);// adiciona ou não?

            foreach (Nota n in notas)
            {
                Console.WriteLine(n.ToString());
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX CONJUNTOS: Classes que herdam de conjuntos");

            // para o c# dois alunos são o mesmo
            // se tiverem a mesma referencia
            // ie se as variáveis estiverem a referenciar
            // o mesmo endereço de memória
            Aluno al4 = al1; // para o c# a4 e a1 são iguais

            // Se não codificarmos os métodos
            // Equals e GetHashCode em ALuno
            // os alunos a5 e a6 são diferentes
            Aluno al5 = new Aluno(5, "Maruane Mendes");
            Aluno al6 = new Aluno(6, "Maruane Mandolo");

            Turma CtespTpsi = new Turma();
            CtespTpsi.NomeDaTurma = "Turma do CTESP TPSI";

            CtespTpsi.Add(al1);
            CtespTpsi.Add(al1);// não é adicionado porque é repetido
            CtespTpsi.Add(al2);
            CtespTpsi.Add(al3);
            CtespTpsi.Add(al4);// não é adicionado porque é == a al1
            CtespTpsi.Add(al5);// é adicionado porque não codificámos Equals e GetHashCode
            CtespTpsi.Add(al6);// é adicionado porque não codificámos Equals e GetHashCode

            Console.WriteLine(CtespTpsi.ToString());

            Console.WriteLine("\nXXXXXXXXXXXXXXX TABELAS: Dictionary<K,V>");
            Console.WriteLine("XXX Tabelas são coleções de pares <chave, valor>" +
                "\nXXX a coleção de chaves não tem elementos repetidos" +
                "\nXXX A coleção de valores pode ter elementos repetidos" +
                "\nXXX Os pares <chave, valor> estão indexados pela chave");

            Dictionary<Aluno, String> nomes = new Dictionary<Aluno, String>();
            nomes.Add(al5,"Maruane M." );
            nomes.Add(al6, "Maruane M.");
            nomes.Add(al1, "Cide Frederiz");
            //nomes.Add(al1, "Mauricio Burdino"); // Exception: "Cide Frederiz porque a chave é a mesma
            nomes.Add(al3, "Abulfadal R. S.");
            //nomes.Add(al4, "Sisnando"); // considerando que al1 == al4 ... o que é feito?
                                        // Os nomes aqui usados são dos cavaleiros que integraram o
                                        // circulo intimo de Sisnando, 1º alvazil cristão de Coimbra por volta de 1050-1060 ;-)

            Console.WriteLine("\nXXXXXXXXXXXXXXX TABELAS: Dictionary<K,V> iterado pelas chaves");
            foreach (Aluno aluno in nomes.Keys)
            {
                Console.WriteLine(aluno.ToString());
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX TABELAS: Dictionary<K,V> iterado pelos valores");
            foreach (String str in nomes.Values)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX TABELAS: Dictionary<K,V> iterado pelos pares <chave,valor>");
            foreach (var v in nomes) // qual o tipo de dados de v?
            {
                Console.WriteLine(v.Value + "\t" + v.Key);
            }

            Console.WriteLine("\nXXXXXXXXXXXXXXX TABELAS: Classes que herdam de Dictionary<K,V>");
            TabelaAlunosNomes nomesDeAlunos = new TabelaAlunosNomes();
            nomesDeAlunos.Add(al1, "Cide Frederiz");
            nomesDeAlunos.Add(al2, "Martinus ibn A.");
            nomesDeAlunos.Add(al3, "Abulfadal R. S.");
            nomesDeAlunos.Add(al5, "Maruane M.");
            nomesDeAlunos.Add(al6, "Maruane M.");

            Console.WriteLine(nomesDeAlunos);

        }
    }
}
