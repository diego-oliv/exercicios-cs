using System;

namespace Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal = 0;
            
            Console.WriteLine("Qual é o seu salário? ");
            sal = double.Parse(Console.ReadLine());

            if (sal < 500)
            {
                Console.WriteLine("Você tem direito a um aumento de 30%. Seu novo salário será de: ");
                Console.WriteLine($"{sal} + 30% = {sal * 1.3}");
            } else {
                Console.WriteLine("VOCÊ JÁ RECEBE MUITO, SAI DAE LOCO!");
            }
        }
    }
}
