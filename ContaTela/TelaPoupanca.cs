﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContaTela
{
    public partial class TelaPoupanca : Form
    {
        public TelaPoupanca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaPoupanca_Load(object sender, EventArgs e)
        {

        }
        List<Poupanca> poupancas = new List<Poupanca>();


        //double valorInicial;
        Poupanca poupanca = new Poupanca(); 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
            poupanca.nome =  txtNome.Text;
            poupanca.cpf  = txtCPF.Text;
            poupanca.id = Convert.ToInt32(txtIdConta.Text);
            poupanca.saldo = Convert.ToDouble(txtSaldo.Text);
            poupanca.dia = Convert.ToInt32(txtData.Text);
            //valorInicial = poupanca.saldo;
            poupancas.Add(poupanca);
            MessageBox.Show(poupanca.exibirDados());
            txtNome.Text = "";
            txtCPF.Text = "";
            txtIdConta.Text = "";
            txtSaldo.Text = "";
            txtData.Text = "";
            txtData.Text = "";



        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {
                    
                    double deposito = Convert.ToDouble(txtSaldo.Text);
                    poupancas[i].saldo = poupancas[i].depositar(deposito);



                    MessageBox.Show($"Saldo atual {poupancas[i].saldo}");
                }
            }
       
            
            
        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {
                    poupancas[i].saldo=   poupancas[i].novoSaldo();
                    string a = "";
                    a += poupancas[i].saldo; 
                    MessageBox.Show(a);
                }
            }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text))
                {

                    double saque =  Convert.ToDouble(txtSaldo.Text);
                    poupancas[i].saldo = poupancas[i].saque(saque);



                    MessageBox.Show($"Saldo atual {poupancas[i].saldo}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                }
            }
        }
    }
}
