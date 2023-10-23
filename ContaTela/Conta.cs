using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    internal class Conta
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int id { get; set; } 
        public double saldo { get; set; }
        public string senha { get; set; }   
        public string exibirDados()
        {

            return ($"Nome: {nome} \n CPF: {cpf} \n Número da conta: {id} \n Saldo: {saldo} \n Informe seu CPF para realizar operações");

        }
        public string erro()
        {
            return "Dados não aprovados";
        }
        public double depositar(double valor)
        {
            return saldo + valor;
        }
        public double saque(double valor)
        {
           return saldo-=valor;
        }
        public string validaInfo()
        {
            if (cpf.Length == 14 && nome.Length > 0 && saldo > 0)
            {
                return exibirDados();
            }
            else 
            {
                return erro();
            }
        }

    }
}
