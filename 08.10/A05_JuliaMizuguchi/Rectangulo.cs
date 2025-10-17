using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_JuliaMizuguchi
{
    // Relação de HERANÇA entre classes
    // Uma (sub)classe HERDA de uma (super)classe (ou classe base)
    // Uma classe É outra classe
    // Rectangulo HERDA de FiguraGeometrica
    // Um Retangulo É Uma FiguraGeometrica 
    // em Java "class Rectangulo extends FiguraGeometrica"
    class Rectangulo : FiguraGeometrica
    {
        // para além do ponto de origem
        private int largura, altura; // Atributos ou campos ... sempre privados camelCase

        // campos da classe iguais para todos os objetos
        // se isso não for da classe,
        // ele nunca vai conseguir contar os objetos
        // é o mesmo endereço de memória para todos os objetos
        // toda vez que cria um, ele vai para o mesmo endereço
        // e incrementa
        // NÃO são constantes
        private static int quantidadeDeRetangulosCriados; 

        // não preciso de getters e setters do ponto
        // porque herdou de FiguraGeometrica
        public int getLargura() { return largura; }
        public void setLargura(int largura) { this.largura = altura; }

        // Só o contrutor com mais parâmetros possui código
        public Rectangulo(Ponto p, int largura, int altura) : base (p)
        // apenas esse construtor invoca o construtor da superclasse
        {
            // só o construtor com mais parâmetros tem código
            this.largura = largura;
            this.altura = altura;
        }

        // Todos os restantes construtores invocam/executam o construtor com mais parâmetros
        public Rectangulo() : this(new Ponto(), 0,0){ } // 0 para a largura e altura
        // e não invoca o construtor da superclasse

        public Rectangulo(int largura, int altura) : this(new Ponto(), largura, altura) { }
        // ao invés de 
        // public Rectangulo(int largura, int altura) { this.largura = largura; this.altura = altura }
        // isso não

        public Rectangulo(Ponto origem) : this(origem, 0, 0) { }


        // Tenho de redefinir o ToSTring de FiguraGeometrica
        // porque o de Rectangulo é diferente
        override public String ToString()
        {
            return base.ToString() + " ["+ largura + "|" + altura + "]";
        }

       // Não preciso de redefinir o Movimentar porque
       // é semelhante ao de FiguraGeometrica

        // Para não ser abstrata
        // Retangulo TEM DE IMPLEMENTAR
        // o método Ampliar
        override public void Ampliar(int factor)
        {
            largura *= factor;
            altura *= factor;
        }
    }
}
