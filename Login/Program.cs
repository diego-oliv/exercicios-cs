using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, senha;

            Console.Write("Digite o usuário: ");
            usuario = Console.ReadLine();
            
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            if ((usuario == "admin") && (senha == "admin")){
                Console.WriteLine("Você entrou como administrador!");
            } else{
                Console.WriteLine ("Você está logado!");
            }
        }
    }
}
