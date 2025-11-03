using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Turma_JMJL
    {
        public String Curso_JMJL { get; set; }
        public int AnoCurricular_JMJL { get; set; }
        public char Letra_JMJL { get; set; }
        public List<Aluno_JMJL> ListaDeAlunos_JMJL { get; set; }

        public Turma_JMJL(string curso_JMJL, int anoCurricular_JMJL, char letra_JMJL)
        {
            Curso_JMJL = curso_JMJL;
            AnoCurricular_JMJL = anoCurricular_JMJL;
            Letra_JMJL = letra_JMJL;
            ListaDeAlunos_JMJL = new List<Aluno_JMJL>();
        }

        // Ao incluirmos uma coleção a uma classe,
        // normalmente temos de codificar os métodos
        // para adicionar e remover elementos dessa coleção
        public void AddAluno_JMJL(Aluno_JMJL aluno_JMJL)
        {
            ListaDeAlunos_JMJL.Add(aluno_JMJL);
        }

        public void RemoveAluno_JMJL(Aluno_JMJL aluno_JMJL)
        {
            ListaDeAlunos_JMJL.Remove(aluno_JMJL);
        }

        public void RemoveAt_JMJL(int i)
        {
            ListaDeAlunos_JMJL.RemoveAt(i);
        }

        public int GetLegth_JMJL()
        {
            return ListaDeAlunos_JMJL.Count;
        }

        public override string ToString()
        {
            String tmp_JMJL = "XXXX Curso: " + Curso_JMJL
                + "\nAno: " + AnoCurricular_JMJL + "\t| Turma_JMJL: " + Letra_JMJL;
            foreach (Aluno_JMJL al_JMJL in ListaDeAlunos_JMJL)
            {
                tmp_JMJL += "\n " + al_JMJL;
            }
            return tmp_JMJL;
        }
    }
}
