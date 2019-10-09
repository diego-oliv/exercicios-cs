using System;
using SENAIzinho.Models;

namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {
            int limiteAlunos = 100;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados;
            int salasCadastradas;
            bool querSair = false;


            System.Console.WriteLine ("------------------------");
            System.Console.WriteLine ("Bem vindo ao SENAIzinho!");
            System.Console.WriteLine ("------------------------");
            System.Console.WriteLine ();

            System.Console.WriteLine ("Selecione o que deseja fazer:");
            System.Console.WriteLine ("1 - Cadastrar Aluno");
            System.Console.WriteLine ("2 - Cadastrar Sala");
            System.Console.WriteLine ("3 - Alocar Aluno");
            System.Console.WriteLine ("4 - Remover Aluno");
            System.Console.WriteLine ("5 - Verificar Sala");
            System.Console.WriteLine ("6 - Verificar Aluno");
            System.Console.WriteLine ("0 - Sair");
            string menu = Console.ReadLine ();

            switch (menu) {
                case "1":
                    break;

                case "2":
                    System.Console.WriteLine ("Cadastrar Sala");
                    System.Console.WriteLine ();
                    break;
            }
        }

        public void CadastrarAluno(){
            System.Console.WriteLine ("Cadastrar Aluno");
            System.Console.WriteLine ();
            System.Console.Write ("Nome Completo: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("Data de Nascimento: ");
            DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());
            System.Console.Write ("Curso: ");
            string curso = Console.ReadLine ();
            System.Console.Write ("Número da Sala: ");
            int numeroSala = int.Parse (Console.ReadLine ());
        }

        public void CadastrarSala(){

        }

        public void AlocarAluno(){

        }

        public void RemoverAluno(){

        }

        public void VerificarSalas(){

        }

        public void VerificarAlunos(){

        }
    }
}