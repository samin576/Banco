using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titular, double saldo, int tipoConta) : base(titular, saldo, tipoConta)
        {
            TipoConta = "Conta Poupança";
            BonusDeposito = 0.005;
            TaxaDeSaque = 0;
        }
    }
}