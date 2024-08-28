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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(50, 116);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(406, 23);
            txtLogradouro.TabIndex = 0;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(52, 63);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(127, 23);
            txtCep.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(492, 116);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(583, 116);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(161, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(50, 170);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(179, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(277, 170);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(492, 170);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(63, 23);
            txtUf.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 23);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 45);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CEP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 45);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 9;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 98);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 98);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 98);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 152);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 152);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 14;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(492, 152);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 16;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
    }
}