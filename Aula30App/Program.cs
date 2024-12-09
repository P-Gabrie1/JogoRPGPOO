
// See https://aka.ms/new-console-template for more information
using Aula30App;
using System.Reflection.PortableExecutable;

//Console.WriteLine("jogo rpg");
//Console.WriteLine("Numero Sorteado");
//Console.WriteLine(Utilitarios.SortearNumero(20,30));

//Carregar as armas
Console.WriteLine("jogo rpg");

List<Arma> armas = new List<Arma>();//armazenar varios objetos em uma variavel
armas.Add(new Arma("", 0, 0));
armas.Add(new Arma("Faca", 5, 10));
armas.Add(new Arma("Espada", 40, 50));
armas.Add(new Arma("Machado", 40, 100));
List<Monstro> monstros = new List<Monstro>();
monstros.Add(new Monstro("Trol", 20, 70, 70));
monstros.Add(new Monstro("Orc", 30, 80, 80));
monstros.Add(new Monstro("Dragão", 46, 200, 200));

//List<Guerreiro> guerreiros = new List<Guerreiro>();
//guerreiros.Add(new Guerreiro(250, 250));



Jogador objJogador = new Jogador(200, 200);

//monstro fixo
objJogador.MonstroAtual = monstros[0];
objJogador.MonstroAtual = monstros[1];
objJogador.MonstroAtual = monstros[2];

do
{

    Console.WriteLine();
    Console.WriteLine("Dados do Jogador");
    Console.WriteLine($"Vida: {objJogador.VidaAtual}/{objJogador.VidaMaxima}");

    Console.WriteLine();
    Console.WriteLine("Dados do Monstro");
    
    Console.WriteLine($"Nome: {objJogador.MonstroAtual.Nome}");
    Console.WriteLine($"Vida: {objJogador.MonstroAtual.VidaAtual}/{objJogador.MonstroAtual.VidaMaxima}");

    Console.WriteLine();
    Console.WriteLine("Escolha Arma: ");
    Console.WriteLine("0 - Resetar ataque");
    Console.WriteLine("1 - Faca");
    Console.WriteLine("2 - Espada");
    Console.WriteLine("3 - Machado");

    //Console.WriteLine();
    //Console.WriteLine("Escolha um jogador");
    //Console.WriteLine("0 - Guerreiro");


    int opcaoArma = Convert.ToInt32(Console.ReadLine());

    objJogador.ArmaAtual = armas[opcaoArma];

    int dano = objJogador.AtacarMonstro();
   Console.WriteLine($"Dano Causado ao {objJogador.MonstroAtual.Nome}:{dano} ");

    //verificação se o jogador ganhou
    if (objJogador.MonstroAtual.VidaAtual <= 0)
    {
        Console.WriteLine("");
        Console.WriteLine($"Parabéns, o {objJogador.MonstroAtual.Nome} foi derrotado");
        break;
    }
    

    int danoSofrido = objJogador.SerAtacado();
    
    Console.WriteLine($"O {objJogador.MonstroAtual.Nome} te tirou: {danoSofrido} de vida");
    Console.WriteLine("");
    //verificação se o monstro ganhou 
    if (objJogador.VidaAtual <= 0)
    {
        Console.WriteLine("Você perdeu!!");
        break;
    }

    Console.ReadLine();
    Console.Clear();
} while (objJogador.VidaAtual > 0 && objJogador.MonstroAtual.VidaAtual>0);
Console.WriteLine("");
Console.WriteLine("Fim de jogo!!");
