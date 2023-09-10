
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
{
    //Tela de inicio
    void telainicial()
    {
        Console.WriteLine(@"
░█████╗░░█████╗░██████╗░███╗░░██╗███████╗██████╗░░█████╗░██╗███╗░░██╗███████╗
██╔══██╗██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔══██╗██║████╗░██║██╔════╝
██║░░╚═╝██║░░██║██████╔╝██╔██╗██║█████╗░░██████╔╝██║░░╚═╝██║██╔██╗██║█████╗░░
██║░░██╗██║░░██║██╔══██╗██║╚████║██╔══╝░░██╔══██╗██║░░██╗██║██║╚████║██╔══╝░░
╚█████╔╝╚█████╔╝██║░░██║██║░╚███║███████╗██║░░██║╚█████╔╝██║██║░╚███║███████╗
░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝╚═╝░░╚══╝╚══════╝
");
        string welcome = "Bem vindo ao CornerCine";


        Console.WriteLine(welcome);

        Console.WriteLine("\n ");

        Console.WriteLine("Created by Bazzo, Matheus ");

        Console.Write("\nDigite seu Usuario: ");
        string User = Console.ReadLine();

        Console.Write("\nDigite sua senha: ");
        string Passw0rd = Console.ReadLine();

        Thread.Sleep(3000); //loading

        //Login efetuado com sucesso
        string Revisao = "\n\r\n█░░ █▀█ █▀▀ █ █▄░█   █▀▀ █▀▀ █▀▀ ▀█▀ █░█ ▄▀█ █▀▄ █▀█   █▀▀ █▀█ █▀▄▀█   █▀ █░█ █▀▀ █▀▀ █▀ █▀ █▀█ █\r\n█▄▄ █▄█ █▄█ █ █░▀█   ██▄ █▀░ ██▄ ░█░ █▄█ █▀█ █▄▀ █▄█   █▄▄ █▄█ █░▀░█   ▄█ █▄█ █▄▄ ██▄ ▄█ ▄█ █▄█ ▄" + "\n" + "\nBem-Vindo:.." + User;

        Console.WriteLine(Revisao);

        Thread.Sleep(3000); //loading
    }
    telainicial();

    bool tela = true;// Gambiarra pra limpar a tela
    if (tela = true) Console.Clear(); // Gambiarra pra limpar a tela

    //Variaveis dos filmes

    string Filme1 = "Diabo Veste Prata";
    string Filme2 = "Soldado Ryan";
    string Filme3 = "ForestGump";
    List<string> Listadefilmes = new List<string>();

    void telaprincipal()
    {
        Console.WriteLine("Selecione opção desejada:..");
        string screen = Console.ReadLine();
        int telaa = int.Parse(screen);
        if (telaa == 1) menu1();
        if (telaa == 2) menu2();

    }
    telaprincipal();
    //Display da Lista diária de filmes

    void menu1()
    {
        Console.WriteLine("\nSegue lista de opções hoje:.." + "\n" + "\n1 - " + Filme1 + "\n2 - " + Filme2 + "\n3 - " + Filme3);
        Console.WriteLine("\nDigite a opção desejada");
        string escolha = Console.ReadLine();
        int Pick = int.Parse(escolha);


        //condição para tipo de filme
        // if (Pick == 1) { Console.WriteLine("\nSucesso1"); }
        // if (Pick == 2) { Console.WriteLine("\nSucesso2"); }
        // if (Pick == 3) { Console.WriteLine("\nSucesso3"); }
        // AO invez de usarmos um if para cada escolha, vamos simplificar em um CASE. 

        switch (Pick) //switch é para quando tenho varios ifs, dentro dele vou incluir o case
        {
            case 1:
                sinopsemovie1();
                break;
            case 2:
                sinopsemovie2();
                break;
            case 3:
                sinopsemovie3();
                break;
            default:
                Console.WriteLine("\nOpção invalida"); //default se for diferente do que já foi colocano no break
                break;

                void sinopsemovie1()
                {
                    Console.WriteLine("Você escolheu .." + Filme1 + "\nEste filme foi aprovado como 97% de margem hotten, e é um dos melhores filmes do seculo 21");
                    Console.Write("\nQual a sua Nota para este filme ");
                    string RateMT = Console.ReadLine(); //Nota filme 1 
                    int Rate_Movie1 = int.Parse(RateMT); //conversão
                    Console.WriteLine("Sua nota foi: " + Rate_Movie1);
                    Thread.Sleep(3000);
                    telaprincipal();
                }
                void sinopsemovie2()
                {
                    Console.WriteLine("Você escolheu .." + Filme2 + "\nEste filme foi aprovado como 97% de margem hotten, e é um dos melhores filmes do seculo 21");
                    Console.Write("\nQual a sua Nota para este filme ");
                    string RateMH = Console.ReadLine(); //Nota filme 1 
                    int Rate_Movie2 = int.Parse(RateMH); //conversão
                    Console.WriteLine("Sua nota foi: " + Rate_Movie2);
                    Thread.Sleep(3000);
                    telaprincipal();
                }
                void sinopsemovie3()
                {
                    Console.WriteLine("Você escolheu .." + Filme3 + "\nEste filme foi aprovado como 97% de margem hotten, e é um dos melhores filmes do seculo 21");
                    Console.Write("\nQual a sua Nota para este filme ");
                    string RateMj = Console.ReadLine(); //Nota filme 1 
                    int Rate_Moviee = int.Parse(RateMj); //conversão
                    Console.WriteLine("Sua nota foi: " + Rate_Moviee);
                    Thread.Sleep(3000);
                    telaprincipal();
                }
        }
    }//Menu de escolhas
    menu1();





    //Display da Lista de preferidos 
    void menu2()
    {



        Console.WriteLine("Informe Opção desejada:..");
        Console.WriteLine("1 - Mostrar lista de filmes");
        Console.WriteLine("2 - Incluir filme na lista");
        string escolhamenu2 = Console.ReadLine();
        int escolham2 = int.Parse(escolhamenu2);

        if (escolham2 == 1) opcao1menu2();
        if (escolham2 == 2) opcao2menu2();


        // switch (opcaomenu2)


        // {
        //  case 1:
        //      opcao1menu2();
        //           break;
        //       case 2:
        //       opcao2menu2();
        //           break;
        //       }

        void opcao1menu2()
        {
            Console.WriteLine("Segue lista de Filmes:..");
            for (int i = 0; i < Listadefilmes.Count; i++)
            {
                Console.WriteLine($" {Listadefilmes[i]}");

            }

            
        }

        void opcao2menu2()
        {
            Console.WriteLine("Digite o seu filme para adiciona-lo na lista");
            string nomefilme = Console.ReadLine();
            Listadefilmes.Add(nomefilme);//adiciona o valor do readline na lista nomefilme
            Console.WriteLine($"{nomefilme} Adicionado a lista de desejos");
            telaprincipal();
        }

    }
}





