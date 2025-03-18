using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
            BonusDeposito = 0.5;
            TaxaDeSaque = 0;


        }
    }
}
