namespace ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo;

        public double Saldo {
            get {return _saldo;}
        }
        public int Agencia {
            get {return _agencia;}
        }
        public int Numero {
            get {return _numero;}
        }
        public Cliente Titular{
            get {return _titular;}
        }

        public ContaCorrente(int Agencia,int Numero,Cliente Titular){
            this._agencia = Agencia;
            this._numero = Numero;
            this._titular = Titular;
            this._saldo = 0.0;
        }
        public double Deposito(double valor){            
            if (valor > 0) {
                this._saldo += valor;
                return this._saldo;
            } else {
                return this._saldo;
            }
            
        }
        public bool Saque(double valor){
            if (valor > 0) {
                if(valor <= this._saldo){
                    this._saldo -= valor;
                    return true;
                } else{
                    return false;
                }
            } else {
                return false;
            }
        }
        public bool Transferencia(ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}