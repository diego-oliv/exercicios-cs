using System;
using Escola_de_Rap.Interfaces;
namespace Escola_de_Rap.Models
{
    public class Violao : Instrumento, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do violão.");
            return true;
        }
    }
}