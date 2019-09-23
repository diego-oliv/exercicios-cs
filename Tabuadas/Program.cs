using System;

namespace Tabuadas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 10; x++){
                for (int y=1; y<=10; y++){
                    Console.Write($"{y,-2} x {x,-2} = {y*x,-3}");
                }
                Console.WriteLine();
            }            
        }
    }
}
