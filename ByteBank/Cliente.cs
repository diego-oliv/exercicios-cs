using System;

namespace ByteBank
{
    public class Cliente
    {
        public string CPF {get ;set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}

        public Cliente (string nome, string cpf, string email)
        {
        this.Nome = nome;
        this.CPF = cpf;
        this.Email = email;
        }

        public bool TrocarSenha (string senha)
        {
            if ((senha.Length > 6) && (senha.Length < 16))
            {
                this.Senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}