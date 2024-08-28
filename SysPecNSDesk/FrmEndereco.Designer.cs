namespace SysPecNSDesk
{
    partial class FrmEndereco
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
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtUf = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTipoEndereco = new TextBox();
            label2 = new Label();
            btnSalvarEndereco = new Button();
            btnAdicionarEndereco = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(32, 101);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(406, 23);
            txtLogradouro.TabIndex = 0;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(34, 48);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(127, 23);
            txtCep.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(474, 101);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(565, 101);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(161, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(32, 155);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(179, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(259, 155);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(474, 155);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(63, 23);
            txtUf.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CEP";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 83);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 10;
            label3.Text = "Logradouro";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 83);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 11;
            label4.Text = "Nº";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 83);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 12;
            label5.Text = "Complemento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 137);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 137);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Cidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 137);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 15;
            label8.Text = "UF";
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(565, 155);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(161, 23);
            txtTipoEndereco.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 17;
            label2.Text = "Tipo de Endereço";
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.Location = new Point(237, 212);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(126, 23);
            btnSalvarEndereco.TabIndex = 18;
            btnSalvarEndereco.Text = "&Salvar endereço";
            btnSalvarEndereco.UseVisualStyleBackColor = true;
            btnSalvarEndereco.Click += btnSalvarEndereco_Click;
            // 
            // btnAdicionarEndereco
            // 
            btnAdicionarEndereco.Location = new Point(415, 212);
            btnAdicionarEndereco.Name = "btnAdicionarEndereco";
            btnAdicionarEndereco.Size = new Size(196, 23);
            btnAdicionarEndereco.TabIndex = 19;
            btnAdicionarEndereco.Text = "&Adicionar outro endereço";
            btnAdicionarEndereco.UseVisualStyleBackColor = true;
            btnAdicionarEndereco.Click += btnAdicionarEndereco_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(661, 212);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 265);
            Controls.Add(btnFechar);
            Controls.Add(btnAdicionarEndereco);
            Controls.Add(btnSalvarEndereco);
            Controls.Add(label2);
            Controls.Add(txtTipoEndereco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtUf);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtCep);
            Controls.Add(txtLogradouro);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            Load += FrmEndereco_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUf;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTipoEndereco;
        private Label label2;
        private Button btnSalvarEndereco;
        private Button btnAdicionarEndereco;
        private Button btnFechar;
    }
}