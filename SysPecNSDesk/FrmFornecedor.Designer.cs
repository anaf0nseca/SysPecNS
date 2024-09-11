namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            dgvFornecedores = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            txtCnpj = new TextBox();
            txtFantasia = new TextBox();
            txtRazaoSocial = new TextBox();
            txtId = new TextBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.BackgroundColor = Color.FromArgb(29, 96, 150);
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Columns.AddRange(new DataGridViewColumn[] { clnId, clnRazaoSocial, clnFantasia, clnCnpj, clnContato, clnTelefone, clnEmail });
            dgvFornecedores.Location = new Point(7, 341);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.RowHeadersVisible = false;
            dgvFornecedores.Size = new Size(620, 227);
            dgvFornecedores.TabIndex = 17;
            dgvFornecedores.CellContentClick += dgvFornecedores_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            clnRazaoSocial.Width = 120;
            // 
            // clnFantasia
            // 
            clnFantasia.HeaderText = "Fantasia";
            clnFantasia.Name = "clnFantasia";
            clnFantasia.ReadOnly = true;
            clnFantasia.Width = 120;
            // 
            // clnCnpj
            // 
            clnCnpj.HeaderText = "CNPJ";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            // 
            // clnContato
            // 
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            clnTelefone.Width = 80;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(txtCnpj);
            groupBox1.Controls.Add(txtFantasia);
            groupBox1.Controls.Add(txtRazaoSocial);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 322);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Fornecedores";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(247, 184);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 51;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(22, 184);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 50;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(279, 131);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 49;
            label5.Text = "Contato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 131);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 48;
            label4.Text = "CNPJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(303, 76);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 47;
            label3.Text = "Fantasia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 46;
            label2.Text = "Razão Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 45;
            label1.Text = "ID";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(247, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 44;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTelefone.ForeColor = Color.Black;
            txtTelefone.Location = new Point(22, 202);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(177, 23);
            txtTelefone.TabIndex = 43;
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtContato.ForeColor = Color.Black;
            txtContato.Location = new Point(279, 149);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(252, 23);
            txtContato.TabIndex = 42;
            // 
            // txtCnpj
            // 
            txtCnpj.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtCnpj.ForeColor = Color.Black;
            txtCnpj.Location = new Point(22, 149);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(219, 23);
            txtCnpj.TabIndex = 41;
            // 
            // txtFantasia
            // 
            txtFantasia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtFantasia.ForeColor = Color.Black;
            txtFantasia.Location = new Point(303, 94);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(295, 23);
            txtFantasia.TabIndex = 40;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtRazaoSocial.ForeColor = Color.Black;
            txtRazaoSocial.Location = new Point(22, 94);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(261, 23);
            txtRazaoSocial.TabIndex = 39;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(22, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 23);
            txtId.TabIndex = 38;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(456, 252);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(142, 45);
            btnConsultar.TabIndex = 37;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(238, 252);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 45);
            btnEditar.TabIndex = 36;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(22, 252);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 45);
            btnAdicionar.TabIndex = 35;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(634, 581);
            Controls.Add(groupBox1);
            Controls.Add(dgvFornecedores);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFornecedores";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvFornecedores;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private TextBox txtCnpj;
        private TextBox txtFantasia;
        private TextBox txtRazaoSocial;
        private TextBox txtId;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
    }
}