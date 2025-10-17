using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07_AULA_JM
{
    internal class Pessoa_JM
    {

        // props com campo implicito -> prop + tab 
        public int Idade { get; set; }

        // props com campo explicito -> propfull + tab
        private String nome;
        // a prop pode ter o nome que eu quiser
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

       
    }
}
