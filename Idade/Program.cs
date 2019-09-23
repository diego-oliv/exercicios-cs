using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int resultado;
            

            Console.Write("Digite o ano em que você nasceu: ");
            idade = int.Parse(Console.ReadLine());

            resultado = 2019 - idade;

            if (resultado <= 2){
                Console.WriteLine("Você é um recém-nascido");
            } else if ((resultado >= 3) && (resultado <=11)){
                Console.WriteLine("Você é uma criança");
            } else if ((resultado >=12) && (resultado >=19)){
                Console.WriteLine("Você é um adolescente");
            } else if ((resultado >=20) && (resultado <=65)) {
                Console.WriteLine("Você é um adulto");
            } else if ((resultado >65)){
                Console.WriteLine("Você é um idoso");
            }
        }
    }
}



