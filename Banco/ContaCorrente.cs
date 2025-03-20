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
        public ContaCorrente(string titular, double saldo, string tipoConta) : base(titular, saldo, tipoConta)
        {
            TipoConta = "Conta Poupança";
            BonusDeposito = 0;
            TaxaDeSaque = 5;

        }

    }
}