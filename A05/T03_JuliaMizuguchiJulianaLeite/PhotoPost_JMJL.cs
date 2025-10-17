using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class PhotoPost_JMJL : Post_JMJL
    {
        private String filename_JMJL;
        private String caption_JMJL;

        public PhotoPost_JMJL(String username_JMJL,
                              String filename_JMJL,
                              String caption_JMJL)
                              : base(username_JMJL)
        {
            // NOTE a invocação do construtor da
            // classe base (da classe Post_JMJL)
            // usando : base(<parametros>)
            this.filename_JMJL = filename_JMJL;
            this.caption_JMJL = caption_JMJL;
        }

        public PhotoPost_JMJL() : this("Anónimo",
                                       "no file",
                                       "no caption")
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
            // invocação do toString da
            // classe base Post
            String toStringDaSuper_JMJL = base.ToString();
            int ultimoC_JMJL =
            toStringDaSuper_JMJL.LastIndexOf("***") + 3;
            String antes =
            toStringDaSuper_JMJL.Substring(0, ultimoC_JMJL);
            String depois_JMJL =
            toStringDaSuper_JMJL.Substring(ultimoC_JMJL);
            String tmp_JMJL = antes + "\n ";
            tmp_JMJL += caption_JMJL + "\n ";
            tmp_JMJL += "[" + filename_JMJL + "]";
            tmp_JMJL += depois_JMJL;
            return tmp_JMJL;
        }
    }
}

