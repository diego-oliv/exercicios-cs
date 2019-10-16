using Escola_de_Rap.Interfaces;
using System;
namespace Escola_de_Rap.Models
{
    public class Teclado : Instrumento, IHarmonia, IMelodia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de teclado.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de teclado.");
            return true;
        }
    }
}