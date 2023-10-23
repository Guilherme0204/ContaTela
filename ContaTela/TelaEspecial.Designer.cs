namespace ContaTela
{
    partial class TelaEspecial
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.rbtnsacar = new System.Windows.Forms.RadioButton();
            this.rbtndepositar = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "especial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(777, 267);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 22);
            this.txtSenha.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Senha";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(422, 538);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 71);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(803, 177);
            this.txtCPF.Mask = "000-000-000,00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(136, 22);
            this.txtCPF.TabIndex = 36;
            // 
            // rbtnsacar
            // 
            this.rbtnsacar.AutoSize = true;
            this.rbtnsacar.Location = new System.Drawing.Point(573, 475);
            this.rbtnsacar.Name = "rbtnsacar";
            this.rbtnsacar.Size = new System.Drawing.Size(64, 20);
            this.rbtnsacar.TabIndex = 34;
            this.rbtnsacar.TabStop = true;
            this.rbtnsacar.Text = "Sacar";
            this.rbtnsacar.UseVisualStyleBackColor = true;
            this.rbtnsacar.CheckedChanged += new System.EventHandler(this.rbtnsacar_CheckedChanged);
            // 
            // rbtndepositar
            // 
            this.rbtndepositar.AutoSize = true;
            this.rbtndepositar.Location = new System.Drawing.Point(415, 475);
            this.rbtndepositar.Name = "rbtndepositar";
            this.rbtndepositar.Size = new System.Drawing.Size(87, 20);
            this.rbtndepositar.TabIndex = 33;
            this.rbtndepositar.TabStop = true;
            this.rbtndepositar.Text = "Depositar";
            this.rbtndepositar.UseVisualStyleBackColor = true;
            this.rbtndepositar.CheckedChanged += new System.EventHandler(this.rbtndepositar_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(580, 538);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 71);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(580, 538);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(133, 71);
            this.btnSacar.TabIndex = 30;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(580, 538);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(133, 71);
            this.btnDepositar.TabIndex = 29;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(48, 257);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(88, 32);
            this.lbSaldo.TabIndex = 27;
            this.lbSaldo.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(139, 157);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(89, 32);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(328, 257);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(111, 32);
            this.txtSaldo.TabIndex = 24;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(277, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 22);
            this.txtNome.TabIndex = 23;
            // 
            // TelaEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 767);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.rbtnsacar);
            this.Controls.Add(this.rbtndepositar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "TelaEspecial";
            this.Text = "TelaEspecial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.RadioButton rbtnsacar;
        private System.Windows.Forms.RadioButton rbtndepositar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNome;
    }
}