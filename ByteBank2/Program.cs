using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente1 = "Diego";
            string cliente2 = "André";
            #region Testando Conta Corrente
            ContaCorrente ContaCorrente1 = new ContaCorrente(1,1,cliente1);
            ContaCorrente ContaCorrente2 = new ContaCorrente(1,2,cliente2);
            ContaCorrente.Deposito(10);
            #endregion
        }
    }
}
