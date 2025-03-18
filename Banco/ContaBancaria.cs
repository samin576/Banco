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
        public int TipoOperacao()
        {
            Console.WriteLine("""
                É uma conta corrente ou poupança?
                1 - Conta poupança
                2 - Conta corrente
                """);
            int resultado = int.Parse(Console.ReadLine());
            return resultado;
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
        public ContaBancaria(string numeroConta, string titular, double saldo)
        {
            this._tipoConta = numeroConta;
            this._titular = titular;
            this._saldo = saldo;
        }
        public ContaBancaria()
        {

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
                Console.WriteLine("Você não pode adicionar um número nulo");
            }
            else
            {
                if (TipoOperacao() == 1)
                {
                    Saldo += valor + (BonusDeposito * valor);
                }
                else if (TipoOperacao() == 2)
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
                if (TipoOperacao() == 1)
                {
                    Saldo -= valor;
                    TipoConta = "Conta Poupança";
                }
                else if (TipoOperacao() == 2)
                {
                    Saldo -= (valor - TaxaDeSaque);
                    TipoConta = "Conta Corrente";
                }
            }
        }
        public void ExibirSaldo()
        {

            Console.WriteLine($"{TipoConta} - Nome: {Titular} | Saldo: {Saldo}");
        }


    }
}