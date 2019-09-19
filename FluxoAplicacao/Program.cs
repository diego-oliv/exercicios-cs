using System;

namespace FluxoAplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            
            Console.Write("Digite sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.Write ("Meses: ");
            Console.WriteLine ($"{age} * {12} = {age * 12}");

            Console.Write ("Dias: ");
            Console.WriteLine ($"{age} * {365} = {age * 365}");

            Console.Write ("Horas: ");
            Console.WriteLine ($"{age} * {8760} = {age * 8760}");

            Console.Write ("Minutos: ");
            Console.WriteLine ($"{age} * {525600} = {age * 525600}");
        }
    }
}
