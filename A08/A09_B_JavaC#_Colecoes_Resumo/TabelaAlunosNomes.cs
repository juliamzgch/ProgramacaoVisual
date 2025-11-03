using JavaCSharp_ColecoesResumo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCSharpColecoesResumo
{
    internal class TabelaAlunosNomes : Dictionary<Aluno, string>
    {
        public override string ToString()
        {
            String tmp = "Nome \t\t\t| Aluno";
            foreach (var v in this) // qual o tipo de dados de v?
            {
                tmp += "\n" + v.Value + "\t\t|" + v.Key;
            }
            return tmp;
        }
    }
}
