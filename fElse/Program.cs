using System;

namespace fElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2 = 0;
            string oper;

            
            Console.Write("Digite o 1º Valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º valor: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Qual operação a ser feita? ");
            oper = (Console.ReadLine());

            switch (oper)
            {
                case "+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

                case "-":
                Console.Write($"{num1} - {num2} = {num1 - num2}");
                break;

                case "*":
                Console.Write($"{num1} * {num2} = {num1 * num2}");
                break;

                case "/":
                Console.Write($"{num1} / {num2} = {num1 / num2}");
                break;

                default:
                Console.WriteLine("COLOCA UM OPERADOR AÍ SEU CABAÇO!");
                    break;
            }

            /*
            if (oper == "+")
            {
               Console.Write($"{num1} + {num2} = {num1 + num2}"); 
            }
            if (oper == "-")
            {
                Console.Write($"{num1} - {num2} = {num1 - num2}");
            }
            if (oper == "*")
            {
                Console.Write($"{num1} * {num2} = {num1 * num2}");
            }
            if (oper == "/")
            {
                Console.Write($"{num1} / {num2} = {num1 / num2}");
            }
            */
        }
    }
}
