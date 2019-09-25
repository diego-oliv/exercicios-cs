using System;

namespace vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            double par = 0;
            double impar = 0;
            int [] vetor = new int [6];
            for (int i = 0; i < 6; i++){
                if (i % 2 == 0){
                    par++;
                }else{
                    impar++;
                }                
            }
            Console.WriteLine("Número de pares é: " + par);
            Console.WriteLine("Número de ímapres é: " + impar);  
        }
    }
}
