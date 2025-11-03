using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_Slides_NA
{
    // QUE PARTE DE
    // TODAS AS CLASSES HERDAM DE OBJECT
    // ``E QUE AINDA NÂO DECORARAM?
    public class Aluno_NA 
    {
        public String Nome_NA { get; set; }
        public String Numero_NA { get; set; }

        public override string ToString()
        {
            return Numero_NA + "\t" + Nome_NA;
        }

        // para comparar dois objetos da classe aluno
        // temos de ser nó programadores a definir dois métodos
        // GetHashCode Equals
        // Vamos considerar que dois alunos são iguais se tiverem numeros iguais
        // o que é um hashCode?
        // um hashCode é um código que (tenta) assegurar que não existem dois elementos
        // com o mesmo hashCode ao mesmo tempo que optimiza a procura dos elementos pelo hashCode
        public override int GetHashCode()
        {
            return Numero_NA.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            // se obj é null
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            } // Se são o mesmo objeto
            if (Object.ReferenceEquals(this, obj)){
                return true;
            } // Se não são do mesmo tipo ... não são iguais ...
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Aluno_NA a = obj as Aluno_NA;
            return String.Equals(Numero_NA, a.Numero_NA);
        }


    }
}
