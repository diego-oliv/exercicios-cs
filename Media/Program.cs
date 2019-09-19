using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3,nota4;
            double media;
            
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é: " + media);

            if (media >= 7)
            {
                Console.WriteLine("Um brinde, você é o cara!");
            } else{
                Console.WriteLine("Como você é burro cara, que loucura!");
            }
        }
    }
}
