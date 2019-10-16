using System;
using Escola_de_Rap.Interfaces;
namespace Escola_de_Rap.Models
{
    public class Tambor : Instrumento, IPercussao
    {
        public bool ManterRitmo()
        {
        System.Console.WriteLine("Mantendo o ritmo com o tambor.");
        return true;
        }
    }
}