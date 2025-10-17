namespace A07_AULA_JM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // quando não há construtores com parâmetros,
            // podemos fazer
           //  Pessoa_JM p1_JM = new Pessoa_JM() 
            // {
                // Nome = "Julia Mizuguchi", // propriedades separadas
             //    Idade = 21                // por VIRGULA
            // }; // a instrucao termina aqui

            // Console.WriteLine(p1_JM.Nome + " | " + p1_JM.Idade);

            // bomba atomica de invocacao
            ExemploEvent_JM exemploEvent_JM = new ExemploEvent_JM();
            exemploEvent_JM.ExemploDeUsoDeEvent(10, 20);
        }
    }
}
