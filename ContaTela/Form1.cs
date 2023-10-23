using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form tela;
        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaPoupanca
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            lbInico.Visible = false;
            pnlTelas.Controls.Add(tela);
            tela.Show();

            MessageBox.Show("Informe seus dados para se cadastrar e informe um valor de saldo para ativar a conta");
        }

        private void bntInvestimento_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaEspecial
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            lbInico.Visible = false;

            pnlTelas.Controls.Add(tela);
            tela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlTelas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
