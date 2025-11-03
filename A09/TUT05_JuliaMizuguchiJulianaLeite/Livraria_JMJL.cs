using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Livraria_JMJL
    {
        public String Nome_JMJL { get; set; }
        public String NIF_JMJL { get; set; }
        public String Url_JMJL { get; set; }
        public List<Livro_JMJL> Livros_JMJL { get;set; }

        public Livraria_JMJL(string nome_JMJL, string nif_JMJL, string url_JMJL)
        {
            Nome_JMJL = nome_JMJL;
            NIF_JMJL = nif_JMJL;
            Url_JMJL = url_JMJL;
            Livros_JMJL = new List<Livro_JMJL>();
        }

        public void AddLivro_JMJL(Livro_JMJL livro_JMJL)
        {
            Livros_JMJL.Add(livro_JMJL);
        }

        public void RemoveLivro_JMJL(Livro_JMJL livro_JMJL)
        {
            Livros_JMJL.Remove(livro_JMJL);
        }

        public void RemoveAt_JMJL(int i)
        {
            Livros_JMJL.RemoveAt(i);
        }

        public int GetLength_JMJL()
        {
            return Livros_JMJL.Count;
        }

        public override string ToString()
        {
            String tmp_JMJL = "Livraria: " + Nome_JMJL
                + "\nNIF: " + NIF_JMJL + "\t| URL: " + Url_JMJL;
            foreach (Livro_JMJL l in Livros_JMJL)
            {
                tmp_JMJL += "\n " + l;
            }
            return tmp_JMJL;
        }

    }
}
