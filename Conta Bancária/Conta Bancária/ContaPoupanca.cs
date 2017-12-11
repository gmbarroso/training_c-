using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancária
{
    public class ContaPoupanca : Conta
    {
        public override bool Saca(double valor)
        {
           if (valor + 0.10 <= this.Saldo)
            {
                this.Saldo -= valor + 0.10;
                return true;
            }
           else
            {
                return false;
            }
        }

    }
}
