using System;

namespace McBonalds
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Endereço {get; set;}
        public string Telefone {get; set;}
        public string Senha{ get; set;}
        public string Email {get; set;}
        public DateTime DataNasc {get; set;}

        //Construtor
        public Cliente(string nome, string telefone, string email){
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}   