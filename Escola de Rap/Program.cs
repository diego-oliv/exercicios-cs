using System;
using Escola_de_Rap.Models;
using Escola_de_Rap.Interfaces;

namespace Escola_de_Rap
{
    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
    }
    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] ItensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] ItensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));
            var opcoesFormacao = new List<string>()
            {
                "    - 0         ",
                "    - 1         "
            };
            int opcaoFormacao = 0;
            string menubar = "==========================";
        }
    }
}
