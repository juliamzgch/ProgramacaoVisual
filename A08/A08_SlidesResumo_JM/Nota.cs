using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08_SlidesResumo_JM
{
    public class Nota
    // para ter composição com Aluno
    // precisa ser public
    {
        public int Valor { get; set; }
        public String Cadeira { get; set; }

        override
            public String ToString()
        {
            return Cadeira + "\t|" + Valor;
        }
    }
}
