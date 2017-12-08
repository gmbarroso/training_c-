using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancária
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo = 100.0;

        //declaração de atributos
        public bool Saca(double valor)
        {
            //Implementação do método
            if (this.saldo >= 100.0)
                //utilizando o this pois a variável está declarada em
                // outra classe
            {
                this.saldo -= 100.0;
                return true;
            }
            return false;

        }

        public void Deposito(double valor)
        {
            this.saldo += valor;
        }


    }
}
