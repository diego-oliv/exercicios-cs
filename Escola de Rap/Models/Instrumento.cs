
using System;
namespace Escola_de_Rap.Models
{
    public class Instrumento
    {
        string [] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};
        public string TocarMusica()
        {
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}