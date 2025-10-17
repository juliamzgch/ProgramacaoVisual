using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_PRATICA_JuliaMizuguchiJulianaLeite
{
    internal class CartaoDoCidadao_JMJL
    {
        String numeroDoCartao_JMJL, nomeDoCidadao_JMJL;

        public CartaoDoCidadao_JMJL(String numeroDoCartao_JMJL, String nomeDoCidadao_JMJL)
        {
            this.numeroDoCartao_JMJL = numeroDoCartao_JMJL;
            this.nomeDoCidadao_JMJL = nomeDoCidadao_JMJL;
        }

        public CartaoDoCidadao_JMJL() : this("Número Indefinido", "S/N")
        {
        }

        public String GetNumeroDoCartao_JMJL()
        {
            return numeroDoCartao_JMJL;
        }

        public String GetNomeDoCidadao_JMJL()
        {
            return nomeDoCidadao_JMJL;
        }

        public void SetNumeroDoCartao_JMJL(String numeroDoCartao_JMJL)
        {
            this.numeroDoCartao_JMJL = numeroDoCartao_JMJL;
        }

        public void SetNomeDoCidadao_JMJL(String nomeDoCidadao_JMJL)
        {
            this.nomeDoCidadao_JMJL = nomeDoCidadao_JMJL;
        }

        override
            public String ToString()
        {
            return "NCC: " + numeroDoCartao_JMJL + " - " + nomeDoCidadao_JMJL;
        }
    }
}
