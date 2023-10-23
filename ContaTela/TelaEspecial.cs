using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContaTela
{
    public partial class TelaEspecial : Form
    {
        public TelaEspecial()
        {
            InitializeComponent();
            btnDepositar.Visible = false;
            btnSacar.Visible = false;
            rbtndepositar.Visible = false;
            rbtnsacar.Visible = false;

            txtSenha.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<Investimento> investimentos = new List<Investimento>();
        Investimento investimento = new Investimento(); 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            investimento.nome = txtNome.Text;

            investimento.cpf = txtCPF.Text;



            investimento.id++;
            investimento.saldo = Convert.ToDouble(txtSaldo.Text);
           
            //poupanca.dia = Convert.ToDateTime(txtData.Text);

            investimento.senha = txtSenha.Text;



            investimentos.Add(investimento);

            MessageBox.Show(investimento.validaInfo());
            txtNome.Text = "";
            txtCPF.Text = "";
            //txtIdConta.Text = "";
            txtSaldo.Text = "";
           
            txtSenha.Text = "";
            rbtndepositar.Visible = true;
            rbtnsacar.Visible = true;
           
        }

        private void rbtndepositar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtndepositar.Checked)
            {
                btnDepositar.Visible = true;
              
                btnSacar.Visible = false;
                rbtndepositar.Visible = false;
                rbtnsacar.Visible = false;
               
                btnCadastrar.Visible = false;
                lbNome.Visible = false;
                txtNome.Visible = false;
                
                lbSaldo.Text = " depósito";
                txtSaldo.Visible = true;
                

                btnDepositar_Click(sender, e);

            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < investimentos.Count; i++)
            {
                if (investimentos[i].cpf.Equals(txtCPF.Text) && investimentos[i].senha.Equals(txtSenha.Text))
                {

                    double deposito = Convert.ToDouble(txtSaldo.Text);
                    investimentos[i].saldo = investimentos[i].depositar(deposito);



                    MessageBox.Show($"Saldo atual {investimentos[i].saldo}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                    rbtndepositar.Visible = true;
                    rbtnsacar.Visible = true;
                   
                }
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < investimentos.Count; i++)
            {
                if (investimentos[i].cpf.Equals(txtCPF.Text) && investimentos[i].senha.Equals(txtSenha.Text))
                {


                    double saque = Convert.ToDouble(txtSaldo.Text);
                    investimentos[i].saldo = Convert.ToDouble(investimentos[i].cheque(saque));



                    MessageBox.Show($"Saldo atual {investimentos[i].saldo}");
                    txtCPF.Text = "";
                    txtSaldo.Text = "";
                    rbtndepositar.Visible = true;
                    rbtnsacar.Visible = true;
                   
                }
            }
        }

        private void rbtnsacar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnsacar.Checked)
            {
                btnDepositar.Visible = false;

                btnSacar.Visible = true;
                rbtndepositar.Visible = false;
                rbtnsacar.Visible = false;

                btnCadastrar.Visible = false;
                lbNome.Visible = false;
                txtNome.Visible = false;

                lbSaldo.Text = " saque";
                txtSaldo.Visible = true;
                btnSacar_Click(sender, e);
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
