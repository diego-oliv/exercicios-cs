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
            string[] Lixos = {"Garrafa PET", "Garrafa de Vidro", "Guarda-Chuva", "Latinha", "Papelão", "Pote de Manteiga"};
            do
            {
                System.Console.WriteLine("Qual lixo deseja descartar?");
                for (i = 0; i < Lixos.Length; i++)
                {
                    System.Console.WriteLine(i + " - " + Lixos[i]);
                }
                System.Console.WriteLine("Digite 'f' para sair.");
                escolha = Console.ReadLine();
            } while (escolha != "f");
        }
    }
}
