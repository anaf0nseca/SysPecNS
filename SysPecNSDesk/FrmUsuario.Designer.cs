namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnInserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            cmbNivel = new ComboBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            label6 = new Label();
            chkAtivo = new CheckBox();
            btnEditar = new Button();
            btnDeletar = new Button();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(107, 276);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(503, 150);
            dgvUsuarios.TabIndex = 0;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(107, 184);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(131, 23);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 23);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 23);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 75);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 75);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Nível";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 125);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(242, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 23);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 9;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(379, 93);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(186, 23);
            cmbNivel.TabIndex = 10;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(108, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(131, 23);
            txtSenha.TabIndex = 11;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(261, 143);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(131, 23);
            txtConfSenha.TabIndex = 12;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 125);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 13;
            label6.Text = "Confirmar senha";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(414, 145);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 14;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(297, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(479, 184);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(131, 23);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "De&letar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(107, 247);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(503, 23);
            txtBusca.TabIndex = 17;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(txtBusca);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(chkAtivo);
            Controls.Add(label6);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(cmbNivel);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btnInserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private ComboBox cmbNivel;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Label label6;
        private CheckBox chkAtivo;
        private Button btnEditar;
        private Button btnDeletar;
        private TextBox txtBusca;
    }
}