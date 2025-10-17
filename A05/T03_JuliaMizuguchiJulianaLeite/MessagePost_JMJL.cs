using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class MessagePost_JMJL : Post_JMJL
    {
        private String message_JMJL;

        public MessagePost_JMJL(String username_JMJL,
                                String message_JMJL) 
                                : base(username_JMJL)
        {
            // NOTE a invocação do construtor da
            // classe base (da classe Post_JMJL)
            // usando : base(<parametros>)
            this.message_JMJL = message_JMJL;
        }

        public MessagePost_JMJL() : this("Anónimo", 
                                         "Vazia") 
        {
            // NOTE QUE de acordo com as BPP
            // invocamos o construtor da própria
            // classe com : this(<parametros>)
            // não invocamos o construtor da
            // classe base (a super classe do Java)
        }

        // note como uma série de métodos do C#: 
        // ToString, LastIndexOf, Substring
        // tem o mesmo nome dos do Java
        // mas em PascalCase
        // porque são públicos ;-)

        override
        public String ToString()
        {
            // invocação do ToString da
            // classe base Post
            String toStringDaSuper_JMJL = base.ToString();
            int ultimoC_JMJL = toStringDaSuper_JMJL.LastIndexOf("***") + 3;
            String antes_JMJL = toStringDaSuper_JMJL.Substring(0, ultimoC_JMJL);
            String depois_JMJL = toStringDaSuper_JMJL.Substring(ultimoC_JMJL);
            String tmp_JMJL = antes_JMJL + "\n " + message_JMJL;
            tmp_JMJL += depois_JMJL;
            return tmp_JMJL;
        }
    }
}
