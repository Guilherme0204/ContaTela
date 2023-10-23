using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    internal class Investimento : Conta
    {
        public double limite { get; set; }


        public double cheque(double valor)
        {
            if (saldo > 1000)
            {
                limite = 1500;
            }
            else
            {
                limite = 500;
            }

            if (saldo <= limite || (valor - saldo) <= limite)
            {
                return saldo -= valor;
            }

            return saldo;
        }

    }
}

