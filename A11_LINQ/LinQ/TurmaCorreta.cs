using System;
using System.Collections.Generic;
using System.Text;

namespace TP06_Collections
{
    class TurmaCorreta
    {

        // Como Turma tem uma propriedade do tipo List<Aluno> 
        // 1. Caso o construtor não receba um parametro para
        //    inicializar o atributo do tipo List<Aluno>
        //    teremos de criar a List<Aluno> no construtor!!!
        // 2. Temos de codificar todos os métodos de List<T> que necessitemos

        public String Curso { get; set; }
        public int Ano { get; set; }
        public String Nome { get; set; }
        // Turma tem um atributo (Propriedade) do tipo List<Aluno>
        //public List<Aluno> Alunos { get; set; }
        private List<Aluno> alunos;
        //public Aluno this[int i] // indexer p/ a lista Alunos
        //{
        //    get { return Alunos[i]; }
        //    set { Alunos[i] = value; }
        //}


        public TurmaCorreta(String curso, int ano, String nome)
        {
            // Como não recebe nenhum parametro
            // para uma List<Aluno>
            // o construtor deve criar uma instancia
            // de List<Aluno>
            alunos = new List<Aluno>();
        }

        // Como turma não é uma List<Aluno>
        // temos de implementar todos os métodos de
        // que possamos necessitar

        public void Add(Aluno al)
        {
            alunos.Add(al);
        }

        public void Remove (Aluno al)
        {
            alunos.Remove(al);
        }

        public void RemoveAt(int i)
        {
            alunos.RemoveAt(i);
        }

        public Aluno GetAt(int i)
        {
            return alunos[i];
        }

        // a única diferença do ToString da classe Alunos é que
        // em turma iteramos a propriedade Alunos
        // em vez de iterar o próprio (this) objeto
        override public String ToString()
        {
            String str = "Turma: " + Nome + " " + Ano + "º ano" + " do" + Curso + "\n";
            foreach (Aluno a in alunos)
            {
                str += a + "\n";
            }
            return str;
        }
    }
}
