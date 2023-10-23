using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    internal class Poupanca : Conta
    {
        public DateTime dia { get; set; }
       public double rendimento { get; set; }
        public double getSaldo()
        {
            return saldo;
        }
        public double novoSaldo()
        {
           int dif = dia.Month - DateTime.Now.Month;
            rendimento = 0.1;
            double novoValor = (dif * rendimento) * saldo + saldo;
            return novoValor;

        }
        
      
    }
}
