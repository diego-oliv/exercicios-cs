using System;
namespace Reciclagem.Models
{
    public class Lixos
    {
        string [] reciclaveis = {"Garrafa PET", "Garrafa de Vidro", "Guarda Chuva", "Latinha", "Papelão", "Pote de Manteiga"};
        public string DescartarLixo()
        {
            int lixo = new Random().Next(reciclaveis.Length - 1);
            return reciclaveis[lixo];
        }
    }

}