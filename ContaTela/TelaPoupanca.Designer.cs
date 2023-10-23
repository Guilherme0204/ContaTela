namespace ContaTela
{
    partial class TelaPoupanca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnRendimento = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbtndepositar = new System.Windows.Forms.RadioButton();
            this.rbtnsacar = new System.Windows.Forms.RadioButton();
            this.rbtnrendimento = new System.Windows.Forms.RadioButton();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "poupanca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(197, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(197, 227);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(111, 32);
            this.txtSaldo.TabIndex = 4;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(59, 127);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(89, 32);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            this.lbNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(59, 227);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(88, 32);
            this.lbSaldo.TabIndex = 9;
            this.lbSaldo.Text = "Saldo";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(307, 337);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(302, 32);
            this.lbData.TabIndex = 10;
            this.lbData.Text = "Tempo de Rendimento";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(500, 508);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(133, 71);
            this.btnDepositar.TabIndex = 11;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(500, 508);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(133, 71);
            this.btnSacar.TabIndex = 12;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnRendimento
            // 
            this.btnRendimento.Location = new System.Drawing.Point(500, 508);
            this.btnRendimento.Name = "btnRendimento";
            this.btnRendimento.Size = new System.Drawing.Size(133, 71);
            this.btnRendimento.TabIndex = 13;
            this.btnRendimento.Text = "Rendimento";
            this.btnRendimento.UseVisualStyleBackColor = true;
            this.btnRendimento.Click += new System.EventHandler(this.btnRendimento_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(500, 508);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 71);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbtndepositar
            // 
            this.rbtndepositar.AutoSize = true;
            this.rbtndepositar.Location = new System.Drawing.Point(335, 445);
            this.rbtndepositar.Name = "rbtndepositar";
            this.rbtndepositar.Size = new System.Drawing.Size(87, 20);
            this.rbtndepositar.TabIndex = 15;
            this.rbtndepositar.TabStop = true;
            this.rbtndepositar.Text = "Depositar";
            this.rbtndepositar.UseVisualStyleBackColor = true;
            this.rbtndepositar.CheckedChanged += new System.EventHandler(this.rbtndepositar_CheckedChanged);
            // 
            // rbtnsacar
            // 
            this.rbtnsacar.AutoSize = true;
            this.rbtnsacar.Location = new System.Drawing.Point(493, 445);
            this.rbtnsacar.Name = "rbtnsacar";
            this.rbtnsacar.Size = new System.Drawing.Size(64, 20);
            this.rbtnsacar.TabIndex = 16;
            this.rbtnsacar.TabStop = true;
            this.rbtnsacar.Text = "Sacar";
            this.rbtnsacar.UseVisualStyleBackColor = true;
            this.rbtnsacar.CheckedChanged += new System.EventHandler(this.rbtnsacar_CheckedChanged);
            // 
            // rbtnrendimento
            // 
            this.rbtnrendimento.AutoSize = true;
            this.rbtnrendimento.Location = new System.Drawing.Point(580, 445);
            this.rbtnrendimento.Name = "rbtnrendimento";
            this.rbtnrendimento.Size = new System.Drawing.Size(101, 20);
            this.rbtnrendimento.TabIndex = 17;
            this.rbtnrendimento.TabStop = true;
            this.rbtnrendimento.Text = "Rendimento";
            this.rbtnrendimento.UseVisualStyleBackColor = true;
            this.rbtnrendimento.CheckedChanged += new System.EventHandler(this.rbtnrendimento_CheckedChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(723, 147);
            this.txtCPF.Mask = "000-000-000,00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(136, 22);
            this.txtCPF.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 508);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 71);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(670, 347);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(98, 22);
            this.txtData.TabIndex = 20;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(697, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 22);
            this.txtSenha.TabIndex = 22;
            // 
            // TelaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 760);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.rbtnrendimento);
            this.Controls.Add(this.rbtnsacar);
            this.Controls.Add(this.rbtndepositar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRendimento);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "TelaPoupanca";
            this.Text = "TelaPoupanca";
            this.Load += new System.EventHandler(this.TelaPoupanca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnRendimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbtndepositar;
        private System.Windows.Forms.RadioButton rbtnsacar;
        private System.Windows.Forms.RadioButton rbtnrendimento;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
    }
}