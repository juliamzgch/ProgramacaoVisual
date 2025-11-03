using System;
using System.Collections.Generic;
using System.Text;

namespace JavaCSharp_ColecoesResumo
{
    class Aluno
    {
        // Propriedades
        public int Codigo { get; set; }
        private String nome;// campos private minuscula

        public String Nome // propriedades publicas Miuscula
        {
            get { return nome; }
            set { nome = value; }
        }

        // composição
        public List<Nota> Notas { get; set; }

        public Aluno(int cod, String nome)
        {
            Codigo = cod;
            Nome = nome;
            // LEMBREM-SE que antes de usar uma coleção
            // TEMOS DE CRIAR o objeto!!!
            Notas = new List<Nota>();
        }

        public Aluno (): this (0, "Sem Nome")
        {

        }

        public void addNota(Nota n)
        {
            Notas.Add(n);
        }

        public override string ToString()
        {
            String str = Codigo + "\t" + Nome;
            foreach (Nota n in Notas)
                str += "\n\t" + n.ToString();
                return  str;
        }
    }
}
