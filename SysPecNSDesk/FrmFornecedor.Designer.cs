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
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            txtId = new TextBox();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            txtCnpj = new TextBox();
            txtContato = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvFornecedores = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(30, 265);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 45);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(246, 265);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 45);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(464, 265);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(142, 45);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(30, 54);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 23);
            txtId.TabIndex = 3;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtRazaoSocial.ForeColor = Color.White;
            txtRazaoSocial.Location = new Point(30, 107);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(261, 23);
            txtRazaoSocial.TabIndex = 4;
            // 
            // txtFantasia
            // 
            txtFantasia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtFantasia.ForeColor = Color.White;
            txtFantasia.Location = new Point(311, 107);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(295, 23);
            txtFantasia.TabIndex = 5;
            // 
            // txtCnpj
            // 
            txtCnpj.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtCnpj.ForeColor = Color.White;
            txtCnpj.Location = new Point(30, 162);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(219, 23);
            txtCnpj.TabIndex = 6;
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtContato.ForeColor = Color.White;
            txtContato.Location = new Point(287, 162);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(252, 23);
            txtContato.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTelefone.ForeColor = Color.White;
            txtTelefone.Location = new Point(30, 215);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(177, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(255, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(311, 89);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 144);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(287, 144);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 14;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 197);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 15;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(255, 197);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 16;
            label7.Text = "Email";
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.BackgroundColor = Color.SteelBlue;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Columns.AddRange(new DataGridViewColumn[] { clnId, clnRazaoSocial, clnFantasia, clnCnpj, clnContato, clnTelefone, clnEmail });
            dgvFornecedores.Location = new Point(30, 332);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.RowHeadersVisible = false;
            dgvFornecedores.Size = new Size(576, 227);
            dgvFornecedores.TabIndex = 17;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supply_truck_box_shipping_transportation_transport_delivery_icon_260527;
            pictureBox1.Location = new Point(523, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(634, 580);
            Controls.Add(pictureBox1);
            Controls.Add(dgvFornecedores);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtContato);
            Controls.Add(txtCnpj);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtId);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFornecedores";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnConsultar;
        private TextBox txtId;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private TextBox txtCnpj;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvFornecedores;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private PictureBox pictureBox1;
    }
}