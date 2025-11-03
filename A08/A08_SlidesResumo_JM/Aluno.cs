using System;
using System.Collections.Generic;
using System.Text;

namespace A08_SlidesResumo_JM
{
    public class Aluno
    {
        public String Nome { get; set; }
        public String Numero { get; set; }

        // como estamos a prototipar e eu não defini
        // construtores ... vamos iniciar o campo
        // logo na declaração

        // NOTE que quando tenho classe composta por listas
        // e para EVITAR passar a lista para o exterior
        // tenho de codificar na classe os métodos
        // da classe List<T> se os quiser usar fora da classe
        private List<Nota> notas = new List<Nota>();


        public void Add(Nota n)
        {
            notas.Add(n);
        }

        // remove pela posição
        public void RemoveAt(int i)
        {
            notas.RemoveAt(i);
        }


        override
        public String ToString()
        {
            // Todas as classes que tenham coleções
            // precisam de um ToString com pelo menos
            // um ciclo para iterar a coleção
            // os seus elementos a uma String
            String tmp = "\n" + Numero + "\t" + Nome + "\n";
            foreach (Nota n in notas)
                tmp += "\n\t\t" + n.ToString();
            return tmp;

        }

        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            // Is null
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }

            // Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            // Is not the same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            // se não retornar ainda
            // é porque são do mesmo tipo

            Aluno a = obj as Aluno;
            return String.Equals(Numero, a.Numero);
        }
    }
}
