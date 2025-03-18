using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
            BonusDeposito = 0;
            TaxaDeSaque = 5;

        }

    }
}