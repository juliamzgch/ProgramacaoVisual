using System;
using System.Collections.Generic;
using System.Text;

namespace JavaCSharp_ColecoesResumo
{
    class Nota
    {
        public String UnidadeCurricular { get; set; }
        public int Avaliacao { get; set; }

        public override string ToString()
        {
            return Avaliacao + "\t" + UnidadeCurricular;

        }
    }
}

