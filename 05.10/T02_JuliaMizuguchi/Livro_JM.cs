using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_JuliaMizuguchi
{
    internal class Livro_JM
    {
        string identificadorUnico_JM;
        string autor_JM;
        string titulo_JM;
        decimal preco_JM;
        int existencias_JM;

        public Livro_JM(string identificadorUnico,
                        string autor,
                        string titulo,
                        decimal preco,
                        int existencias)
        {
            this.identificadorUnico_JM = identificadorUnico;
            this.autor_JM = autor;
            this.titulo_JM = titulo;
            this.preco_JM = preco;
            this.existencias_JM = existencias;
        }

        public Livro_JM() : this("IU_000000000",
                            "Sem Autor Definido", 
                            "Sem Titulo Definido",
                            0.0M,
                            0)
        {
        }

        public string GetIdentificadorUnico_JM() { return  identificadorUnico_JM; }
        public string GetAutor_JM() { return autor_JM; }
        public string GetTitulo_JM() { return titulo_JM; }
        public decimal GetPreco_JM() { return preco_JM; }
        public int GetExistencias_JM() { return existencias_JM; }

        public void SetIdentificadorUnico_JM(string identificadorUnico)
        {
            identificadorUnico_JM = identificadorUnico;
        }

        public void SetAutor_JM(string autor)
        {
            autor_JM = autor;
        }
        public void SetTitulo_JM(string titulo)
        {
            titulo_JM = titulo;
        }
        public void SetPreco_JM(decimal preco)
        {
            preco_JM = preco;
        }
        public void SetExistencias_JM(int existencias)
        {
            existencias_JM = existencias;
        }

        override
        public String ToString()
        {
            String tmp = "*** LIVRO: " + identificadorUnico_JM
                + " | Tit: " + titulo_JM
                + " | Aut: " + autor_JM
                + " | $$: " + preco_JM
                + " | Stock: " + existencias_JM;
            return tmp;
        }







    }
}
