using System;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do triângulo: ");
            int alturaT = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de triângulos: ");
            int qteT = int.Parse(Console.ReadLine());

            for (int i = 0; i < qteT; i++){
                string estrelas = "";
                for(int j = 0; j < alturaT; j++){
                    estrelas += "*";
                    Console.WriteLine(estrelas);
                }
                Console.WriteLine();            
            }
        }
    }
}
