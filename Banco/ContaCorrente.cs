using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
        }
    }
}