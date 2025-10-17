using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_PRATICA_JuliaMizuguchiJulianaLeite
{
    internal class Docente_JMJL : Cidadao_JMJL
    {
        String categoriaProfissional_JMJL, gabinete_JMJL;

        public Docente_JMJL(CartaoDoCidadao_JMJL CartaoDoCidadao_JMJL, DateTime dataDeNascimento_JMJL,
                            String categoriaProfissional_JMJL, String gabinete_JMJL) : base(CartaoDoCidadao_JMJL, dataDeNascimento_JMJL)
        {
            this.categoriaProfissional_JMJL = categoriaProfissional_JMJL;
            this.gabinete_JMJL = gabinete_JMJL;
        }

        public Docente_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime(), "Categoria Indefinida", "Gabinete Indefinido")
        { }

        public String GetCategoriaProfissional_JMJL()
        {
            return categoriaProfissional_JMJL;
        }

        public String GetGabinete_JMJL()
        {
            return gabinete_JMJL;
        }

        public void SetCategoriaProfissional_JMJL(String categoriaProfissional_JMJL)
        {
            this.categoriaProfissional_JMJL = categoriaProfissional_JMJL;
        }

        public void SetGabinete_JMJL(String gabinete_JMJL)
        {
            this.gabinete_JMJL = gabinete_JMJL;
        }

        override
        public String ToString()
        {
            return "Docente: " + gabinete_JMJL + " - " 
                + categoriaProfissional_JMJL + "   " + base.ToString();
        }
    }
}
