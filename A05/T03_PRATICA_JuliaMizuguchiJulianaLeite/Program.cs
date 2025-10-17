namespace T03_PRATICA_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CartaoDoCidadao_JMJL cartao1_JMJL = new CartaoDoCidadao_JMJL("123456789", "Julia");
            CartaoDoCidadao_JMJL cartao2_JMJL = new CartaoDoCidadao_JMJL();

            Console.WriteLine(cartao1_JMJL.ToString());
            Console.WriteLine(cartao2_JMJL.ToString());

            cartao1_JMJL.SetNomeDoCidadao_JMJL("Julia Mizuguchi");

            Console.WriteLine(cartao1_JMJL.ToString());

            Cidadao_JMJL cidadao1_JMJL = new Cidadao_JMJL(cartao1_JMJL, new DateTime(1995, 5, 15));
            Cidadao_JMJL cidadao2_JMJL = new Cidadao_JMJL();

            Console.WriteLine(cidadao1_JMJL.ToString());
            Console.WriteLine(cidadao2_JMJL.ToString());

            Aluno_JMJL aluno1_JMJL = new Aluno_JMJL(cartao1_JMJL, new DateTime(1995, 5, 15), "2021001", "2021001@gmail.com");

            Console.WriteLine(aluno1_JMJL.ToString());

            Aluno_JMJL aluno2_JMJL = new Aluno_JMJL();

            Console.WriteLine(aluno2_JMJL.ToString());

            aluno2_JMJL.SetNumeroDeAluno_JMJL("1922282");
            Console.WriteLine(aluno2_JMJL);

            Cidadao_JMJL docente1_JMJL = new Docente_JMJL(cartao1_JMJL, new DateTime(1980, 3, 20), "Professor Adjunto", "101");

            Console.WriteLine(docente1_JMJL.ToString());

            docente1_JMJL.SetCartaoDoCidadao_JMJL(cartao2_JMJL);

            Console.WriteLine(docente1_JMJL.ToString());

        }
    }
}
