using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_JuliaMizuguchi
{
    internal class Dvd_JM
    {
        string identificadorUnico_JM;
        string titulo_JM;
        string realizador_JM;
        int duracao_JM;
        double preco_JM;
        int existencias_JM;

        public Dvd_JM(string identificadorUnico,
                     string titulo,
                     string realizador,
                     int duracao,
                     double preco,
                     int existencias)
        {
            this.identificadorUnico_JM = identificadorUnico;
            this.titulo_JM = titulo;
            this.realizador_JM = realizador;
            this.duracao_JM = duracao;
            this.preco_JM = preco;
            this.existencias_JM = existencias;
        }

        public Dvd_JM() : this("IU_000000000",
                         "Sem Titulo Atribuido",
                         "Sem Realizador Definido",
                         0,
                         0.0,
                         0)
        {
        }

        public string GetIdentificadorUnico_JM() { return identificadorUnico_JM; }
        public string GetTitulo_JM() { return titulo_JM; }
        public string GetRealizador_JM() { return realizador_JM; }
        public int GetDuracao_JM() { return duracao_JM; }
        public double GetPreco_JM() { return preco_JM; }
        public int GetExistencias_JM() { return existencias_JM; }

        public void SetIdentificadorUnico_JM(string identificadorUnico)
        {
            identificadorUnico_JM = identificadorUnico;
        }
        public void SetRealizador_JM(string realizador)
        {
            realizador_JM = realizador;
        }
        public void SetTitulo_JM(string titulo)
        {
            titulo_JM = titulo;
        }
        public void SetDuracao_JM(int duracao)
        {
            duracao_JM = duracao;
        }
        public void SetPreco_JM(double preco)
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
            String tmp = "*** DVD: " + identificadorUnico_JM
                + " | Tit: " + titulo_JM
                + " | Rea: " + realizador_JM
                + " | Dur: " + duracao_JM
                + " | $$: " + preco_JM
                + " | Stock: " + existencias_JM;
            return tmp;
        }





    }
}
