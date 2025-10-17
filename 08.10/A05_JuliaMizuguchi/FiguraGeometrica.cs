using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_JuliaMizuguchi
{
    // Uma classe asbtrata é uma classe que não pode ser instanciada
    // da qual não podemos criar objetos
    // serve para agregar código numa super classe da qual nunca existirão objetos
    abstract class FiguraGeometrica //: IMovimentavel
    {
        // RELAÇÃO DE COMPOSIÇÂO ENTRE CLASSES
        // uma classe TEM um objeto de outra classe
        // uma classe É COMPOSTA pr objetos de outras classes
        // A Classe FiguraGeometrica É COMPOSTA por um Ponto
        // esse é o atributo da classe
        private Ponto origem;

        // getters e setters dessse atributo
        public Ponto getOrigem() { return origem; }
        public void setOrigem(Ponto novaOrigem) { origem = novaOrigem; }


        public FiguraGeometrica(Ponto origem)
        {
            this.origem = origem;
        }

        // construtor sem parâmetros
        // ele invoca o construtor com parâmetros
        // criando um ponto com valores por defeito
        public FiguraGeometrica() : this (new Ponto()) { }

        virtual
        public void Movimentar(int dx, int dy)
        {
            origem.Movimentar(dx, dy);
        }

        // vai usar o ToString do ponto
        // ela dá override porque
        // todas as classes herdam de Object
        public override string ToString()
        {
            return origem.ToString();
        }

        // se a classe tiver (nem que seja) um método abstrato ...
        // a classe tem de ser abstrata
        abstract public void Ampliar(int factor);
        // não tem corpo
        // não há {}
        // os métodos abstratos servem para . . .
        // serem implementados nas subclasses CONCRETAS

    }
}
