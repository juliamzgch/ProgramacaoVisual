using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Livro_JMJL
    {
        public String Titulo_JMJL { get;set; }
        public String ISBN_JMJL { get;set; }
        public Autor_JMJL Autor_JMJL { get;set; }
        public int Stock_JMJL { get;set; }

        public Livro_JMJL(string titulo_JMJL, string isbn_JMJL, Autor_JMJL autor_JMJL, int stock_JMJL)
        {
            Titulo_JMJL = titulo_JMJL;
            ISBN_JMJL = isbn_JMJL;
            Autor_JMJL = autor_JMJL;
            Stock_JMJL = stock_JMJL;
        }

        public override string ToString()
        {
            return "Título: " + Titulo_JMJL
                + "\nISBN: " + ISBN_JMJL
                + "\nAutor: " + Autor_JMJL
                + "\nStock: " + Stock_JMJL;
        }
    }
}
