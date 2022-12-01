using ExerTratamentoDeExcecoes.ContaBancaria.Excecoes;
using System;

namespace ExerTratamentoDeExcecoes.ContaBancaria
{
    internal class Conta
    {
        public int NumeroDaConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroDaConta, string titular, double saldo, double limiteDeSaque)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            Saldo = valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new Excecao("O valor excede o saldo atual da sua conta.");
            }
            
            if (valor > LimiteDeSaque)
            {
                throw new Excecao("O valor excede o limite de saque.");
            }

            Saldo -= valor;
        }
    }
}
