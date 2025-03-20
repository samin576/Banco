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
        private string _tipoConta;
        private string _titular;
        private double _saldo;
        private double _taxaDeSaque;
        private double _bonusDeposito;

        public ContaBancaria(string titular, double saldo, string tipoConta)
        {
            this._tipoConta = tipoConta;
            this._titular = titular;
            this._saldo = saldo;
        }
        public ContaBancaria()
        {
        }
        public double BonusDeposito
        {
            get { return _bonusDeposito; }
            set { _bonusDeposito = value; }
        }
        public double TaxaDeSaque
        {
            get { return _taxaDeSaque; }
            set
            {
                _taxaDeSaque = value;
            }
        }
        public string TipoConta
        {
            get { return _tipoConta; }
            set
            {
                _tipoConta = value;
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
            if (valor < 0)
            {
                Console.WriteLine("Você não pode adicionar um número negativo");
            }
            else
            {
                if (this is ContaPoupanca)
                {
                    Saldo += valor + (BonusDeposito * valor);
                }
                else if (this is ContaCorrente)
                {
                    Saldo += valor;
                }
                else
                {
                    Console.WriteLine("Opção não cadastrada!");
                }
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
                if (this is ContaPoupanca)
                {
                    Saldo -= valor;
                }
                else if (this is ContaCorrente)
                {
                    Saldo -= (valor + TaxaDeSaque);
                    if (valor + TaxaDeSaque > Saldo)
                    {
                        Console.WriteLine("Lamento, mas acrescentando a taxa de 5 reais a sua transição fica impossível de ser realizada");
                    }
                }
            }
        }
        public void ExibirSaldo()
        {
            if (Saldo < 0)
            {
                Console.WriteLine("Operação cancelada!");
            }
            else { Console.WriteLine($"{TipoConta} - Nome: {Titular} | Saldo: {Saldo} reais"); }
        }
    }
}