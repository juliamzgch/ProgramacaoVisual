using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_PRATICA_JuliaMizuguchiJulianaLeite
{
    internal class Aluno_JMJL : Cidadao_JMJL
    {
        String numeroDeAluno_JMJL, email_JMJL;

        public Aluno_JMJL(CartaoDoCidadao_JMJL cartaoDoCidadao, DateTime dataDeNascimento_JMJL,
                          String numeroDeAluno_JMJL, String email_JMJL) : base(cartaoDoCidadao, dataDeNascimento_JMJL)
        {
            this.numeroDeAluno_JMJL = numeroDeAluno_JMJL;
            this.email_JMJL = email_JMJL;
        }

        public Aluno_JMJL() : this(new CartaoDoCidadao_JMJL(), new DateTime(), "Número de Aluno Indefinido", "Sem email")
        { }

        public String GetNumeroDeAluno_JMJL()
        {
            return numeroDeAluno_JMJL;
        }

        public String GetEmail_JMJL()
        {
            return email_JMJL;
        }

        public void SetNumeroDeAluno_JMJL(String numeroDeAluno_JMJL)
        {
            this.numeroDeAluno_JMJL = numeroDeAluno_JMJL;
        }

        public void SetEmail_JMJL(String email_JMJL)
        {
            this.email_JMJL = email_JMJL;
        }



        override
        public String ToString()
        {
            return "Aluno: " + numeroDeAluno_JMJL + "      " + base.ToString();

        }
    }
}
