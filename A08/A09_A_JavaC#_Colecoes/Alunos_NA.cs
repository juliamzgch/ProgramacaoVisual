using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10_Slides_NA
{
    internal class Alunos_NA : List<Aluno_NA>
    {
        // Como Alunos herda (é uma) List de Aluno_NA
        // 1. Tem todos os métodos da classe genérica List<T>
        // 2. Só teremos de codificar o ToString()
        override
        public String ToString()
        {
            // também não podemos usar o foreach
            // neo for ... se quisermos alterar a coleção dentro do ciclo
            // adicionar ou remover elementos
            String tmp = "";
            foreach (Aluno_NA item in this)
            {
                tmp += item + "\n";
            }
            return tmp;
        }

    }
}
