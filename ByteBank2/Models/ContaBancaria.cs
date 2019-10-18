namespace ByteBank2.Models
{
    public abstract class ContaBancaria
    {
        public string Titular;
        public int Agencia;
        public int DigitoConta;
        public double Saldo;
        public ContaBancaria (int agencia, int digitoConta, string titular)
        {
            this.Agencia = agencia;
            this.DigitoConta = digitoConta;
            this.Titular = titular;
            this.Saldo = 0.0;
        }
        public abstract bool Saque(double valor);0
        public bool Deposito(double valor)
        {
            if (valor >= 0)
            {
                this.Saldo += valor;
                return true;
            }
            return false;
        }
        public bool Transferencia(double valor)
        {
            return true;
            if (this.Saque(valor))
            {
                Deposito(valor);
                return true;
            }
            return false;
        }
    }
}