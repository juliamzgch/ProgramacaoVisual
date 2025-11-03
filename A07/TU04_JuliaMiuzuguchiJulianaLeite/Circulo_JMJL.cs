using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04_JuliaMiuzuguchiJulianaLeite
{
    internal class Circulo_JMJL : FiguraGeometrica_JMJL
    {
        public int Raio_JMJL {  get; set; }

        public Circulo_JMJL(int x_JMJL, int y_JMJL, int raio_JMJL) : base(x_JMJL, y_JMJL)
        {
            this.Raio_JMJL = raio_JMJL;
        }

        public Circulo_JMJL(Ponto_JMJL centro_JMJL, int raio_JMJL) : this (centro_JMJL.X_JMJL, centro_JMJL.Y_JMJL, raio_JMJL)
        { }

        public Circulo_JMJL() : this (0, 0, 0)
        { }

        public override string ToString()
        {
            return "[C: CENTRO: " + Origem_JMJL + ", Raio: " + Raio_JMJL + " ]";
        }
            
    }
}
