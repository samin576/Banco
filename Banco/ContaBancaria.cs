using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            this._numeroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldo;
        }
        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                _numeroConta = value;
            }
        }
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public void Depositar(double valor)
        {

            if (valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Não tem como adicionar um valor negativo!");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para sacar!");
            }
            else
            {
                Saldo -= valor;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"CRIAR TIPO CONTA - Nome: {Titular} | Saldo {Saldo}");
        }


    }
}