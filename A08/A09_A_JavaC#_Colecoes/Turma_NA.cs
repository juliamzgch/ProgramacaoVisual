using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_Slides_NA
{
    internal class Turma_NA
    {
        public String Curso { get; set; }
        public int Ano { get; set; }
        public String Nome { get; set; }

        // REGRA: NÂO GOSTAMOS DE ABRIR AS PORTAS
        // A aletrações á lista
        // no exterior da classe
        // PORQUÊ?
        private List<Aluno_NA> listaDeAlunos; // tenho de criar a lista no construtor!!!

        // NÂO GOSTAMOS DE RECEBER LISTAS DO EXTERIOR ...
        public Turma_NA (String c, int ano, String nome)
        {
            // TODOS OS CAMPOS/PROPS São inicialziados no construtor
            Curso = c;
            Ano = ano;
            Nome = nome;
            listaDeAlunos = new List<Aluno_NA>(); //LEMBREM-SE DE CRIAR A LSITA NO CONSTRUTOR!
        }

        public void Add(Aluno_NA a)
        {
            listaDeAlunos.Add(a);
        }

        public void Remove(Aluno_NA a)
        {
            listaDeAlunos.Remove(a);
        }

        // uma das diferenças entre ter uma lista ou ser uma lista
        // é que os ciclos iteram o atributo/campo (listaDeAlunos)
        // em lugar de se iterar a sí p´ropria
        override
        public String ToString()
        {
            String tmp = "Turma: " + Nome + "  " + Ano + "º ano  " + Curso;
            foreach (Aluno_NA item in listaDeAlunos)
            {
                tmp += "\n" + item;
            }
            return tmp;
        }
    }
}
