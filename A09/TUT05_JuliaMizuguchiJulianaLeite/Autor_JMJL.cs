using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Autor_JMJL
    {
        public String Nome_JMJL { get; set; }
        public String LinguaOriginal_JMJL { get; set; }

        public Autor_JMJL(string nome_JMJL, string linguaOriginal_JMJL)
        {
            Nome_JMJL = nome_JMJL;
            LinguaOriginal_JMJL = linguaOriginal_JMJL;
        }

        public override string ToString()
        {
            return Nome_JMJL + " (" + LinguaOriginal_JMJL + ")";
        }
    }
}
