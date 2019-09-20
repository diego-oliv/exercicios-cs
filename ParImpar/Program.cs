using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            do {
                Console.Write("Digite um número (Press '0' to cancel): ");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                    if (num % 2 == 0)
                        {
                            Console.WriteLine("Esse número é par");                
                        } else {
                            Console.WriteLine("Esse número é ímpar");
                        } 
                } while (num != 0);
        }
    }
}
