using System;

namespace Menu_Continha
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            double area;
            double areabase;
            double altura;
            double lado;
            double lM;
            double lm;
            double raio;
            double bM;
            double bm;
            double pi = 3.14;

            do
            {
            Console.WriteLine("Digite 1 para área do quadrado");
            Console.WriteLine("Digite 2 para área do triângulo");
            Console.WriteLine("Digite 3 para área do círculo");
            Console.WriteLine("Digite 4 para área do trapézio");
            Console.WriteLine("Digite 5 para área do retângulo");
            Console.WriteLine("Digite 6 para área do losango");
            Console.WriteLine("Digite 'f' para cancelar");

            menu = Console.ReadLine();

            switch (menu){
                case "1":                
                Console.Write("Digite a medida dos lados: ");
                lado = double.Parse(Console.ReadLine());
                area = lado * lado;
                Console.WriteLine("A área é " + area);
                break;

                case "2":
                Console.Write("Digite a medida da base: ");
                areabase = double.Parse(Console.ReadLine());
                Console.Write("Digite a medida da altura: ");
                altura = double.Parse(Console.ReadLine());
                area = areabase * altura;
                Console.WriteLine("A área é " +area);
                break;

                case "3":                
                Console.Write("Digite a medida do raio: ");
                raio = double.Parse(Console.ReadLine());
                area = (2 * pi * raio);
                Console.WriteLine("A área é " + area);
                break;

                case "4":                
                Console.Write("Digite a medida da base maior:");
                bM = double.Parse(Console.ReadLine());
                Console.Write("Digite a medida da base menor: ");
                bm = double.Parse(Console.ReadLine());
                Console.Write("Digite a medida da altura: ");
                altura = double.Parse(Console.ReadLine());
                area = ((bM + bm) /2) * altura;
                Console.WriteLine("A área é " + area);
                break;

                case "5":
                Console.Write("Digite a medida da base: ");
                areabase = double.Parse(Console.ReadLine());
                Console.Write("Digite a medida da altura: ");
                altura = double.Parse(Console.ReadLine());
                area = areabase * altura;
                Console.WriteLine("A área é " + area);
                break;

                case "6":                
                Console.Write("Digite a área do lado maior: ");
                lM = double.Parse(Console.ReadLine());
                Console.Write("Digite a área do lado menor: ");
                lm = double.Parse(Console.ReadLine());
                area = (lM*lm)/2;
                Console.WriteLine("A área é " + area);
                break;
                } 
            } while (menu != "f");
                
        }
    }
}

