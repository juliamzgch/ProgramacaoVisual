using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT05_JuliaMizuguchiJulianaLeite
{
    internal class Aluno_JMJL : Pessoa_JMJL
    {
        public String NumeroDeAluno_JMJL { get; set;  }

        public Aluno_JMJL(String nome_JMJL, 
            DateTime dataDeNascimento_JMJL, 
            CartaoDoCidadao_JMJL cartao_JMJL, 
            String numeroDeAluno_JMJL) 
            : base(nome_JMJL, dataDeNascimento_JMJL, cartao_JMJL)
        {
            NumeroDeAluno_JMJL = numeroDeAluno_JMJL;
        }

        public override bool Equals(object obj)
        {
            //Is null (como o objeto que invoca não pode ser null)
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }
            //Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            //Not same type
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            //Is the same type -> podemos fazer cast seguro
            Aluno_JMJL a = obj as Aluno_JMJL;
            return String.Equals(NumeroDeAluno_JMJL,
                               a.NumeroDeAluno_JMJL);
        }

        public override int GetHashCode()
        {
            return NumeroDeAluno_JMJL.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + "\t " + 
                "CODAL: " + NumeroDeAluno_JMJL;
        }
    }
}
