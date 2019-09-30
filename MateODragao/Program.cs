using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão         ");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine ("      1 - Iniciar o Jogo     ");
                System.Console.WriteLine ("      0 - Sair  do  Jogo     ");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                    Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Soren";
                        guerreiro.Sobrenome = "Windsor";
                        guerreiro.CidadeNatal = "Asgard";
                        guerreiro.DataNascimento = DateTime.Parse("12/12/340");
                        guerreiro.FerramentaAtaque = "Maça Pesada";
                        guerreiro.FerramentaProtecao = "Armadura Pesada";
                        guerreiro.Forca = 2;
                        guerreiro.Agilidade = 2;
                        guerreiro.Inteligencia = 4;
                        guerreiro.Vida = 5000;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Alduin";
                        dragao.Forca = 4;
                        dragao.Agilidade = 1;
                        dragao.Inteligencia = 4;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, estejas preparado para conhecer a tua ruína!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humano fútil, quem pensas que és para dirigir a palavra a mim?");

                        System.Console.WriteLine();
                        System.Console.Write("Aperte ENTER para prosseguir...");
                        Console.ReadLine();
                        /* FIM - Primeiro diálogo */

                        /*INÍCIO - Segundo diálogo */
                        Console.Clear();
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}. Vim de {guerreiro.CidadeNatal} para acabar com a sua detestável vida..");

                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Quem? De onde? Bom... Que seja! Você pagará pela sua insolência, criatura irritante.");

                        System.Console.WriteLine();
                        System.Console.Write("Aperte ENTER para prosseguir...");
                        Console.ReadLine();
                        /*FIM - Segundo diálogo */
                        Console.Clear();

                        bool PrimeiroAtaque = guerreiro.Agilidade > dragao.Agilidade ? true : false;
                        bool JogadorNaoCorreu = true;
                        int PoderAtaque = guerreiro.Forca > guerreiro.Agilidade ? guerreiro.Forca + guerreiro.Inteligencia : guerreiro.Forca + guerreiro.Agilidade;

                        /*Início da treta */
                        if (PrimeiroAtaque) {
                            Console.Clear();
                            System.Console.WriteLine(" *** Turno do Jogador *** ");
                            System.Console.WriteLine("Escolha sua ação: ");
                            System.Console.WriteLine("1 - Atacar!");
                            System.Console.WriteLine("2 - Fugir");
                            string opcaoBatalha = Console.ReadLine();
                            
                            switch (opcaoBatalha)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    int guerreiroAgilidadeTotal = guerreiro.Agilidade + numeroAleatorioJogador;
                                    int dragaoAgilidadeTotal = dragao.Agilidade + numeroAleatorioDragao;

                                    if (guerreiroAgilidadeTotal > dragaoAgilidadeTotal) {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Tu vais morrer criatura desprezível!");
                                        dragao.Vida -= PoderAtaque + 5;
                                        System.Console.WriteLine("----------");
                                        System.Console.WriteLine("HP Dragão: " + dragao.Vida);
                                        System.Console.WriteLine("HP Guerreiro: " + guerreiro.Vida);
                                    } else {
                                        System.Console.WriteLine("*o dragão desviou do golpe*");
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Como eu esperava, você é um humanóide fraco");
                                    }
                                break;
                                case "2":
                                    JogadorNaoCorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Essa batalha está longe de acabar!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Desistir é a melhor escolha a ser feita, vá chorar no colo da sua mamãezinha!");

                                break;
                            }
                            System.Console.WriteLine("Aperte ENTER para prosseguir.");
                            Console.ReadLine();

                            if (dragao.Vida > 0 && guerreiro.Vida > 0 && JogadorNaoCorreu == true) {
                                Console.Clear();
                                Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    int guerreiroAgilidadeTotal = guerreiro.Agilidade + numeroAleatorioJogador;
                                    int dragaoAgilidadeTotal = dragao.Agilidade + numeroAleatorioDragao;

                                    if ( dragaoAgilidadeTotal > guerreiroAgilidadeTotal) {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Tens certeza que quer continuar com isso?");
                                        guerreiro.Vida -= dragao.Forca;
                                        System.Console.WriteLine("----------");
                                        System.Console.WriteLine("HP Dragão: " + dragao.Vida);
                                        System.Console.WriteLine("HP Guerreiro: " + guerreiro.Vida);
                                    } else {
                                        System.Console.WriteLine("*você desviou do golpe*");
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Você é endeusado apenas por tolos, é fraco como uma mosca!");
                            }
                            
                        }                       
                        /*Fim da treta */
                    } 
                    break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando inválido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    }
}