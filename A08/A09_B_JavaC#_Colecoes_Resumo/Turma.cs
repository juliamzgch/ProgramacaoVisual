using System;
using System.Collections.Generic;
using System.Text;

namespace JavaCSharp_ColecoesResumo
{
    class Turma : HashSet<Aluno>
    {
        public String NomeDaTurma { get; set; }

        public override string ToString()
        {
            String str = "**********\n"
                + NomeDaTurma;
            foreach (Aluno tiago in this)
            {
                str += "\n" + tiago;
            }
            return str;
        }


    }
}
