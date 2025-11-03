using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU04_JuliaMiuzuguchiJulianaLeite
{
    internal class Retangulo_JMJL : FiguraGeometrica_JMJL
    {
        public int X2_JMJL { get; set; }
        public int Y2_JMJL { get; set; }

        public Retangulo_JMJL(int x_JMJL, int y_JMJL, int x2_JMJL, int y2_JMJL) : base(x2_JMJL, y2_JMJL)
        {
            X2_JMJL = x2_JMJL;
            Y2_JMJL = y2_JMJL;
        }

        public Retangulo_JMJL(Ponto_JMJL p1_JMJL, Ponto_JMJL p2_JMJL) : this(p1_JMJL.X_JMJL, p1_JMJL.Y_JMJL, p2_JMJL.X_JMJL, p2_JMJL.Y_JMJL)
        { }

        public Retangulo_JMJL() : this (0, 0, 0, 0)
        { }

        // NOTE QUE em C# é obrigatório marcar com [< override >] membros da classe que escondam os membros
        // da classe base, os quais terão de estar marcados com [< virtual >]
        // NOTE AINDA QUE: se não pretender que o membro com identificador igual o da classe base
        // esconda o da classe base terá de o marcar com [< new >]
        public override void Desloca_JMJL(int dx_JMJL, int dy_JMJL)
        {
            base.Desloca_JMJL(dx_JMJL, dy_JMJL);
            X2_JMJL += dx_JMJL;
            Y2_JMJL += dy_JMJL;
        }

        public override string ToString()
        {
            return "[R: ORIGEM: " + base.ToString() + " , (" + X2_JMJL + "," + Y2_JMJL + ")]";
        }
    }
}
