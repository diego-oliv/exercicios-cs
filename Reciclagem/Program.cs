using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string escolha;
            string divisao = "====================================================";
            string[] Lixos = {"Garrafa PET", "Garrafa de Vidro", "Guarda-Chuva", "Latinha", "Papelão", "Pote de Manteiga"};
            do
            {
                System.Console.WriteLine("Qual lixo deseja descartar?");
                for (i = 0; i < Lixos.Length; i++)
                {
                    System.Console.WriteLine(i + " - " + Lixos[i]);
                }
                System.Console.WriteLine("Digite 'f' para sair.");
                escolha = Console.ReadLine().ToLower();
                switch (escolha)
                {
                    case "0":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IPlastico plastico = new GarrafaPET();
                        plastico.DescartarPlastico();
                        System.Console.WriteLine(divisao);
                    break;
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IVidro garrafaVidro = new GarrafaVidro();
                        garrafaVidro.DescartarVidro();
                        System.Console.WriteLine(divisao);
                    break;
                    case "2":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IMetal guardaChuva = new GuardaChuva();
                        guardaChuva.DescartarMetal();
                        System.Console.WriteLine(divisao);
                    break;
                    case "3":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IMetal latinha = new Latinha();
                        latinha.DescartarMetal();
                        System.Console.WriteLine(divisao);
                    break;
                    case "4":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IPapel papelao = new Papelao();
                        papelao.DescartarPapel();
                        System.Console.WriteLine(divisao);
                    break;
                    case "5":
                        Console.Clear();
                        System.Console.WriteLine(divisao);
                        IPlastico poteManteiga = new PoteManteiga();
                        poteManteiga.DescartarPlastico();
                        System.Console.WriteLine(divisao);
                    break;
                }
            } while (escolha != "f");
        }
    }
}
