using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancária
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        public virtual bool Saca(double valor)
        {
            return true;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }


    }




}
