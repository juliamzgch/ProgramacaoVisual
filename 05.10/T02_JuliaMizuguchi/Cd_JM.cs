using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_JuliaMizuguchi
{
    internal class Cd_JM
    {
        string identificadorUnico_JM;
        string titulo_JM;
        string interprete_JM;
        int duracao_JM;
        decimal preco_JM;
        int existencias_JM;

        public Cd_JM(string identificadorUnico,
                     string titulo,
                     string interprete,
                     int duracao,
                     decimal preco,
                     int existencias)
        {
            this.identificadorUnico_JM = identificadorUnico;
            this.titulo_JM = titulo;
            this.interprete_JM = interprete;
            this.duracao_JM = duracao;
            this.preco_JM = preco;
            this.existencias_JM = existencias;
        }

        public Cd_JM() : this("IU_000000000",
                         "Sem Titulo Atribuido",
                         "Sem Interprete Definido",
                         0,
                         0.0M,
                         0)
        { 
        }

        public string GetIdentificadorUnico_JM() { return identificadorUnico_JM; }
        public string GetTitulo_JM() { return titulo_JM; }
        public string GetInterprete_JM() { return interprete_JM; }
        public int GetDuracao_JM() { return duracao_JM; }
        public decimal GetPreco_JM() { return preco_JM; }
        public int GetExistencias_JM() { return existencias_JM; }

        public void SetIdentificadorUnico_JM(string identificadorUnico)
        {
            identificadorUnico_JM = identificadorUnico;
        }

        public void SetInterprete_JM(string interprete)
        {
            interprete_JM = interprete;
        }
        public void SetTitulo_JM(string titulo)
        {
            titulo_JM = titulo;
        }
        public void SetDuracao_JM(int duracao)
        {
            duracao_JM = duracao;
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
            String tmp = "*** CD: " + identificadorUnico_JM
                + " | Tit: " + titulo_JM
                + " | Inte: " + interprete_JM
                + " | Dur: " + duracao_JM
                + " | $$: " + preco_JM
                + " | Stock: " + existencias_JM;
            return tmp;
        }


    }
}
