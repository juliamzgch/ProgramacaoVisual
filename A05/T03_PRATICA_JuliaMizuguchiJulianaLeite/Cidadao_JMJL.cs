using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_PRATICA_JuliaMizuguchiJulianaLeite
{
    internal class Cidadao_JMJL
    {
        CartaoDoCidadao_JMJL cartaoDoCidadao_JMJL;
        DateTime dataDeNascimento_JMJL;

        public Cidadao_JMJL(CartaoDoCidadao_JMJL cartaoDoCidadao_JMJL, DateTime dataDeNascimento_JMJL)
        {
            this.cartaoDoCidadao_JMJL = cartaoDoCidadao_JMJL;
            this.dataDeNascimento_JMJL = dataDeNascimento_JMJL;
        }

        public Cidadao_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime())
        {
        }

        public CartaoDoCidadao_JMJL GetCartaoDoCidadao_JMJL()
        {
            return cartaoDoCidadao_JMJL;
        }

        public DateTime GetDataDeNascimento_JMJL()
        {
            return dataDeNascimento_JMJL;
        }

        public void SetCartaoDoCidadao_JMJL(CartaoDoCidadao_JMJL cartaoDoCidadao_JMJL)
        {
            this.cartaoDoCidadao_JMJL = cartaoDoCidadao_JMJL;
        }

        public void SetDataDeNascimento_JMJL(DateTime dataDeNascimento_JMJL)
        {
            this.dataDeNascimento_JMJL = dataDeNascimento_JMJL;
        }

        override
        public String ToString()
        {
            return cartaoDoCidadao_JMJL.ToString() + " - Data de Nascimento: " + dataDeNascimento_JMJL.ToShortDateString();
        }
    }
}
