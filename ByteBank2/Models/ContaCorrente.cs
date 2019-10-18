namespace ByteBank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int agencia, int numeroConta, string titular) : base(agencia,numeroConta,titular)
        {
            
        }
        public override bool Saque (double valor)
        {
            if (valor >= 0)
            {
                if (valor <= this.Saldo)
                {
                this.Saldo -= valor;
                return true;
                } else
                {
                    return false;
                }
            }
            return false;
        }
    }
}