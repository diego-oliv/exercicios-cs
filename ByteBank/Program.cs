using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine(" *Cadastro de Clientes* ");
            System.Console.WriteLine();
            
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Cpf: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Cliente cliete = new Cliente (nome, cpf, email);

            bool senhaOk =  false;

            do {
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();
                if (!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requisitos");
                } else {
                    System.Console.WriteLine("Senha trocada com sucesso");
                }
            } while(senhaOk);
        }    
    }
}
