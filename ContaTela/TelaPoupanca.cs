using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ContaTela
{
    public partial class TelaPoupanca : Form
    {
        public TelaPoupanca()
        {
            InitializeComponent();
            btnDepositar.Visible = false;
            btnRendimento.Visible = false;
            btnSacar.Visible = false;
            rbtndepositar.Visible = false;
            rbtnsacar.Visible = false;
            rbtnrendimento.Visible = false;
            lbData.Visible = false;
            txtData.Visible = false;
            
           
            txtSenha.PasswordChar = '*';
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


        
        Poupanca poupanca = new Poupanca(); 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          poupanca.nome =  txtNome.Text;
            
                poupanca.cpf = txtCPF.Text;


           
            poupanca.id++;
            poupanca.saldo = Convert.ToDouble(txtSaldo.Text);
            //poupanca.dia = Convert.ToDateTime(txtData.Text);
            
            poupanca.senha = txtSenha.Text;
            


            poupancas.Add(poupanca);
            
            MessageBox.Show(poupanca.validaInfo());
            
            
            txtNome.Text = "";
            txtCPF.Text = "";
            //txtIdConta.Text = "";
            txtSaldo.Text = "";
            txtData.Text = "";
            txtData.Text = "";
            txtSenha.Text = "";
            rbtndepositar.Visible = true;
            rbtnsacar.Visible = true;
            rbtnrendimento.Visible = true;



        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text) && poupancas[i].senha.Equals(txtSenha.Text))
                {
                    
                    double deposito = Convert.ToDouble(txtSaldo.Text);
                    poupancas[i].saldo = poupancas[i].depositar(deposito);



                    MessageBox.Show($"Saldo atual {poupancas[i].saldo}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                    rbtndepositar.Visible = true;
                    rbtnsacar.Visible = true;
                    rbtnrendimento.Visible = true;
                }
            }

           

        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text) && poupancas[i].senha.Equals(txtSenha.Text))
                {
                    poupanca.dia = Convert.ToDateTime(txtData.Text);

                    poupancas[i].saldo = poupancas[i].novoSaldo();
                    MessageBox.Show("Valor do rendimento  com a taxa de juros a 10% mensais " + poupancas[i].saldo);
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                    rbtndepositar.Visible = true;
                    rbtnsacar.Visible = true;
                    rbtnrendimento.Visible = true;
                }
            }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < poupancas.Count; i++)
            {
                if (poupancas[i].cpf.Equals(txtCPF.Text) && poupancas[i].senha.Equals(txtSenha.Text))
                {

                    double saque =  Convert.ToDouble(txtSaldo.Text);
                    poupancas[i].saldo = Convert.ToDouble(poupancas[i].saque(saque));



                    MessageBox.Show($"Saldo atual {poupancas[i].saldo}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                    rbtndepositar.Visible = true;
                    rbtnsacar.Visible = true;
                    rbtnrendimento.Visible = true;
                }
            }
        }

        private void rbtndepositar_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtndepositar.Checked)
            {
                btnDepositar.Visible = true;
                btnRendimento.Visible = false;
                btnSacar.Visible = false;
                rbtndepositar.Visible = false;
                rbtnsacar.Visible = false;
                rbtnrendimento.Visible = false;
                btnCadastrar.Visible = false;
                lbNome.Visible = false;
                txtNome.Visible = false;
                //lbConta.Visible = false;
                //txtIdConta.Visible = false;
                lbSaldo.Text = "depósito";
                lbData.Visible = false;
                txtData.Visible = false;


                btnDepositar_Click(sender, e);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbtnsacar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnsacar.Checked)
            {
                btnDepositar.Visible = false;
                btnRendimento.Visible = false;
                btnSacar.Visible = true;
                rbtndepositar.Visible = false;
                rbtnsacar.Visible = false;
                rbtnrendimento.Visible = false;
                btnCadastrar.Visible = false;
                lbNome.Visible = false;
                txtNome.Visible = false;
               // lbConta.Visible = false;
                //txtIdConta.Visible = false;
                lbSaldo.Text = " Saque";
                lbData.Visible = false;
                txtData.Visible = false;
                btnSacar_Click(sender, e);  
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnrendimento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnrendimento.Checked)
            {
                btnDepositar.Visible = false;
                btnRendimento.Visible = true;
                btnSacar.Visible = false;
                rbtndepositar.Visible = false;
                rbtnsacar.Visible = false;
                rbtnrendimento.Visible = false;
                btnCadastrar.Visible = false;
                lbNome.Visible = false;
                txtNome.Visible = false;
               // lbConta.Visible = false;
               // txtIdConta.Visible = false;

                //lbSaldo.Text = "Informe o valor do Saque";
                lbData.Visible = true;
                txtData.Visible = true;
                btnRendimento_Click(sender, e); 
            }
        }
    }
}
