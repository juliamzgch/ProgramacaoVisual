using System;
using System.Collections.Generic;
using System.Linq;

namespace TP06_TutorialLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXXXXXX 1 TESTE DA LISTA");
            Alunos alunos = new Alunos();
            Console.WriteLine(alunos.ToString());

            Console.ReadKey();

            Console.WriteLine("XXXXXXXXXXX 2 Todos os nomes de alunos");
            var todos1 = from i in alunos select i.Nome;
            foreach (var i in todos1)
                Console.WriteLine(i.ToString());
            var todos2 = from i in alunos select i.Contacto;
            foreach (var i in todos2)
                Console.WriteLine(i.ToString());
            var todos3 = from i in alunos select i.Contacto.Mail;
            foreach (var i in todos3)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXX 4 Todas as Cadeiras:");
            var todos4 = from i in alunos select i.Cadeiras;
            foreach (var i in todos4)
                foreach (UnidadeCurricular c in i)
                Console.WriteLine(c.ToString());
            Console.ReadKey();

            Console.WriteLine("\n XXXXXXXXXX 5 Todos Ordenados Por Nome");
            var todosPorNomes = from i
                                in alunos
                                orderby i.Nome
                                select i.Nome;
            foreach (var i in todosPorNomes)
                Console.WriteLine(i.ToString());
            var todosPorTelefone = from i
                                   in alunos
                                   orderby i.Contacto.Telefone
                                   select i.Contacto;
            foreach (var i in todosPorTelefone)
                Console.WriteLine(i.ToString());
            var todosPorMail = from i
                               in alunos
                               orderby i.Contacto.Mail
                               select i.Contacto.Mail;
            foreach (var i in todosPorMail)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 6 Todos Por ordem descendente");
            var porNomesDescendentes = from i
                                       in alunos
                                       orderby i.Nome descending
                                       select i.Nome;
            foreach (var i in porNomesDescendentes)
                Console.WriteLine(i.ToString());
            var porTelefonesDescendente = from i
                                          in alunos
                                          orderby i.Contacto.Telefone descending
                                          select i.Contacto;
            foreach (var i in porTelefonesDescendente)
                Console.WriteLine(i.ToString());
            var porMailDescendente = from i
                                     in alunos
                                     orderby i.Contacto.Mail descending
                                     select i.Contacto.Mail;
            foreach (var i in porMailDescendente)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 7 Contém Começa e Termina");

            var claudias = from i
                           in alunos
                           where i.Nome.Contains("Cláudia")
                           select i;
            foreach (var i in claudias)
                Console.WriteLine(i.ToString());
            Console.WriteLine();
            var comecaPorAn = from i in alunos
                              where i.Nome.StartsWith("An")
                              select i.Nome;
            foreach (var i in comecaPorAn)
                Console.WriteLine(i.ToString());
            Console.WriteLine();
            var terminaEmA = from i in alunos
                             where i.Nome.EndsWith("a")
                             select i.Nome;
            foreach(var i in terminaEmA)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\nXXXXXXXXXXX 8 Take, Skip e Group By");

            var tresAlunosDaLei = (from i in alunos
                                   where i.Curso == Curso.LEI
                                   select i.Nome).Take(7);

            Console.WriteLine("XXXXX Primeiros 7 da LEI");

            foreach (var aluno in tresAlunosDaLei)
                Console.WriteLine(aluno);

            Console.WriteLine("\nXXXX 4 e 5 da LEI");
            var quartoEQuinto = (from i in alunos
                                 where i.Curso == Curso.LEI
                                 select i.Nome).Take(5).Skip(3);
            foreach (var aluno in quartoEQuinto)
                Console.WriteLine(aluno);

            Console.WriteLine("\nXXXXX Agrupados por curso");
            // var alunosPorCurso = alunos.GroupBy(aluno => aluno.Curso);
            var alunosPorCurso = from i in alunos
                                 group i.Nome
                                 by i.Curso;
            foreach (var curso in alunosPorCurso)
            {
                Console.WriteLine("XXXXXXXXXXXXXXX CURSO: " + curso.Key);
                foreach (var aluno in curso)
                    Console.WriteLine(aluno);
            }


        }
    }
}