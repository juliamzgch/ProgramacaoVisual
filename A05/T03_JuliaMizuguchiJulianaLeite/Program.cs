namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************************************"
                            + "\n***** 1.2 Teste das Classes  "
                            + "\n*****     MessagePostSh_JMJL e PhotoPostSh_JMJL"
                            + "\n* Não usando herança, mesmo para um programa"
                            + "\n* tão simples como o deste exemplo"
                            + "\n* a quantidade de código repetido é substancial"
                            + "\n* superior a 80%"
                            + "\n* Entre as classes MessagePost e PhotoPost "
                            + "\n* temos 5 atributos duplicados:"
                            + "\n* username, message/caption, timestamp, likes, comments"
                            + "\n* Temos 4 métodos iguais (duplicados!)"
                            + "\n* like, unlike, getComments, gettimeStamp, timeString"
                            + "\n* um toString praticamente igual nas 2 classes"
                            + "\n* um erro em qualquer deste método são certamente"
                            + "\n* dois erros e o segundo precisa de testes próprios para"
                            + "\n* ser identificado");

            Console.WriteLine("\n***********************************************");
            Console.WriteLine("***** 1.2 Um objeto MessagePostSh_JMJL sem herança");
            MessagePostSh_JMJL mpSh_JMJL = 
                         new MessagePostSh_JMJL("Jonh Bastide", "Olá! Já cá estou!");
            mpSh_JMJL.AddComment("Yeah! Tudo bem?");
            Console.WriteLine(mpSh_JMJL);;

            Console.WriteLine("\n***********************************************");
            Console.WriteLine("***** 1.2 Um objeto PhotoPostSh_JMJL sem herança");
            PhotoPostSh_JMJL ppSh_JMJL =
                new PhotoPostSh_JMJL("Josué Bastiddeiro", "Tamém", "\\top\\simles\\bigsimle.jpg");
            ppSh_JMJL.AddComment("Sem brincadeiras");
            Console.WriteLine(ppSh_JMJL);

            Console.WriteLine("\n*****************************************"
                            + "\n***** 1.4 Teste das Classe NewsFeedSh_JMJL  "
                            + "\n* Já a classe NewsFeedSh_JMJL, não usando herança,"
                            + "\n* sofre de problemas ainda mais graves do"
                            + "\n* que a duplicação de código para manipular"
                            + "\n* as duas listas. Repare que sem (muito) código"
                            + "\n* adicional, primeiro apresentam-se todos os posts"
                            + "\n* de texto e depois os de imagens, quando deveriam"
                            + "\n* ser apresentados por ordem de inserção no mural");

            NewsFeedSh_JMJL myNf_JMJL = new NewsFeedSh_JMJL();
            myNf_JMJL.AddMessagePost_JMJL(mpSh_JMJL);
            myNf_JMJL.AddPhotoPost_JMJL(ppSh_JMJL);
            myNf_JMJL.AddMessagePost_JMJL(new MessagePostSh_JMJL("Juan Barallobre",
                                                                    "Finalmente chegaste, " +
                                                                    "tava difícil"));
            myNf_JMJL.AddPhotoPost_JMJL(new PhotoPostSh_JMJL("Josué Barallobre",
                                                            "Logo á tarde?",
                                                            "\\top\\simles\\smallsmile.jpg"));

            Console.WriteLine(myNf_JMJL);


            Console.WriteLine("\n*****************************************"
                            + "\n***** 2 Rede Social COM herança"
                            + "\n* 1. Criamos uma classe Post com os membros"
                            + "\n*    repetidos nas classes MessagePost e PhotoPost "
                            + "\n*    (campos e métodos)"
                            + "\n* 2. A classe MessagePost_JMJL herda de Post"
                            + "\n*    (o extends do Java que em C# se define) com : )"
                            + "\n*    e assim fica com tudo o que Post tem,"
                            + "\n*    adicionamos-lhe e alteramos"
                            + "\n* 3. A classe PhotoPost herda ( : ) de Post e também"
                            + "\n*    herda tudo que Post tem, resta adicionar e alterar"
                            + "\n*    o que é particular de PhotoPost"
                            + "\n* 4. A classe NewsFeed passa a ter uma coleção de Post à"
                            + "\n*    adicionamos mensagens e imagens indiferenciadamente"
                            + "\n*    que serão apresentadas por ordem de inserção executando"
                            + "\n*    os respectivos métodos graças ao polimorfismo");

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.1 Dois objetos da classe Post_JMJL");

            Post_JMJL post1_JMJL = new Post_JMJL("Juan Bastidero");
            post1_JMJL.AddComment("Arriba Arriba Yeeh!");
            Post_JMJL post2_JMJL = new Post_JMJL();
            post1_JMJL.AddComment("Fake Account for sure");
            Console.WriteLine(post1_JMJL + "\n" + post2_JMJL);



            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.4A Dois objetos da classe MesssagePost_JMJL");

            MessagePost_JMJL mp1_JMJL = new MessagePost_JMJL("Iosif Bastidov",
                                                                    "From Russia with love");
            mp1_JMJL.AddComment("no comments!");

            Post_JMJL post3_JMJL = new Post_JMJL();
            MessagePost_JMJL mp2_JMJL = new MessagePost_JMJL("Outro JB", 
                                                             "Mais um fake profile");

            Console.WriteLine(mp1_JMJL + "\n" + mp2_JMJL);

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.4A Dois objetos da classe MesssagePost_JMJL");

            PhotoPost_JMJL pp1_JMJL = new PhotoPost_JMJL("Iosif Bastidov",
                                                            "C:\\logonaraiz\\getalife.gif",   
                                                                    "Só pa chatear");
            pp1_JMJL.AddComment("Arriba Arriba Yeeh!");
            PhotoPost_JMJL pp2_JMJL = new PhotoPost_JMJL();
            pp2_JMJL.AddComment("Fake Account for sure");
            Console.WriteLine(pp1_JMJL + "\n" + pp2_JMJL);

            Console.WriteLine("*****************************************");
            Console.WriteLine("***** 2.5 Teste da classe NewsFeed");
            NewsFeed_JMJL nf1_JMJL = new NewsFeed_JMJL();
            nf1_JMJL.AddPost_JMJL(pp1_JMJL);
            nf1_JMJL.AddPost_JMJL(mp1_JMJL);
            nf1_JMJL.AddPost_JMJL(mp2_JMJL);
            nf1_JMJL.AddPost_JMJL(pp2_JMJL);
            Console.WriteLine(nf1_JMJL);




        } // fecha o main
    } // fecha a classe
} // fecha o namespace
