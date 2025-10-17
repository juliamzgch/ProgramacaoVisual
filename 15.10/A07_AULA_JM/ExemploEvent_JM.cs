using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07_AULA_JM
{
    internal class ExemploEvent_JM
    {
        // um event é uma coleção de delegates
        // um delegate é uma referência para um tipo de métodos
        // logo um event é
        // uma coleção de referências para um tipo de métodos
        // 

        // declaração de um event
        public event Action<int, int> MyEvent;
        // Action: procedimento
        // aceita dois inteiros como parametro

        public void ExemploDeUsoDeEvent(int i, int j)
        {
            // delegate implicito?
            // <INSCREVE> um procedimento tradicional no evento
            MyEvent += MetodoParaOMyEvent;

            // delegate explicito?
            // <INSCREVE> um delegate no no evento
            MyEvent += delegate (int x, int y)
            {
                Console.WriteLine("Do Método Anonimo"); 
            };

            // expressao lambda
            // <INSCREVE> uma expressão lambda no evento
            MyEvent += (x, y) =>
            { Console.WriteLine("Da Expressão Lambda: " + x + y); };

            // <DISPARA> (trigger) o evento
            MyEvent?.Invoke(i, j);
        }

        public static void MetodoParaOMyEvent(int x, int y)
        {
            Console.WriteLine("Do Método Tradicional: " + x + y);
        }
    }
}
