using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titular, double saldo) : base(titular, saldo)
        {
            TipoConta = "Conta Poupança";
            BonusDeposito = 0.005;
            TaxaDeSaque = 0;
        }
    }
}
