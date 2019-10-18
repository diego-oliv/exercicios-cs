namespace ByteBank2.Models
{
    public class ContaEspecial : ContaBancaria
    {
        public double limite;
        public ContaEspecial(int agencia, int numeroConta, string titular) : base (agencia,numeroConta,titular)
        {
            limite = 0.0;
        }

        public override bool Saque (double valor)
        {
            if (valor >= 0)
            {
                if (valor <= base.Saldo + limite)
                {
                    Saldo -= valor;
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool setLimit(double valor)
        {
            if (limite >= 0){
            limite = valor;
            return true;
            }
        return false;
        }
    }
}