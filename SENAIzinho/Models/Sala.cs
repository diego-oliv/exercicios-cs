using System;
namespace SENAIzinho.Models
{
    public class Sala
    {
        public int CapacidadeAtual;
        public int CapacidadeTotal;
        public int NumeroSala;
        public string[] Alunos;
        public string  AlocarAluno (string aluno){
        
        }
        public string  RemoverAluno (string aluno){

        }
        public string MostrarAlunos (){

        }

        public Sala (int capacidadeAtual, int capacidadeTotal){
            this.CapacidadeAtual = capacidadeTotal;
            this.CapacidadeTotal = capacidadeTotal;
            this.CapacidadeTotal = 10;
        }
    }
}