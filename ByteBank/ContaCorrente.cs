using System;

namespace ByteBank
{
    public class ContaCorrente
    {
    public Cliente Titular {get; set;}
    public int Agencia {get; set;}
    public int Numero {get; set;}
    public double Saldo {get; set;}

    public ContaCorrente (int Agencia, int Numero, Cliente Titular){
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Titular = Titular;
        this.Saldo = 0.0;
        }
    public double DepositarValor (double ValorDeposito){
        this.Saldo += ValorDeposito;
        return this.Saldo;
        }    
    public double SacarValor (double SacarValor){
        this.Saldo -= SacarValor;
        return this.Saldo;
        }
    }
}