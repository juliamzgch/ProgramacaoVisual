using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08_SlidesResumo_JM
{
    public class Turma : List<Aluno>
    {
        public override String ToString()
        {
            String tmp = "";
            foreach (Aluno a in this)
            { 
                tmp += "\n" + a.ToString();
            }
            return tmp;
        }

    }
}
