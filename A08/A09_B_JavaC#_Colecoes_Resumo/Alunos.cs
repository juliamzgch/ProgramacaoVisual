using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCSharp_ColecoesResumo
{
    internal class Alunos : List<Aluno>
    {

        override public String ToString()
        {
            String str = "";
            foreach (Aluno a in this)
            {
                str += "\n" + a;
            }
            return str;
        }

    }
}
