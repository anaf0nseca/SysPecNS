namespace SysPecNSDesk
{
    partial class FrmConsultaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tabConsultaCliente = new TabControl();
            tabPageBuscar = new TabPage();
            label1 = new Label();
            dgvEnderecos = new DataGridView();
            clnIdEnd = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEnd = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txtBusca = new TextBox();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            tabPageEditar = new TabPage();
            btnCadastrarEnd = new Button();
            btnSalvar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            groupBox1.SuspendLayout();
            tabConsultaCliente.SuspendLayout();
            tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPageEditar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabConsultaCliente);
            groupBox1.Location = new Point(1, -19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 623);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tabConsultaCliente
            // 
            tabConsultaCliente.Controls.Add(tabPageBuscar);
            tabConsultaCliente.Controls.Add(tabPageEditar);
            tabConsultaCliente.Location = new Point(6, 22);
            tabConsultaCliente.Name = "tabConsultaCliente";
            tabConsultaCliente.SelectedIndex = 0;
            tabConsultaCliente.Size = new Size(764, 595);
            tabConsultaCliente.TabIndex = 0;
            // 
            // tabPageBuscar
            // 
            tabPageBuscar.Controls.Add(label1);
            tabPageBuscar.Controls.Add(dgvEnderecos);
            tabPageBuscar.Controls.Add(label7);
            tabPageBuscar.Controls.Add(txtBusca);
            tabPageBuscar.Controls.Add(dgvClientes);
            tabPageBuscar.Location = new Point(4, 24);
            tabPageBuscar.Name = "tabPageBuscar";
            tabPageBuscar.Padding = new Padding(3);
            tabPageBuscar.Size = new Size(756, 567);
            tabPageBuscar.TabIndex = 0;
            tabPageBuscar.Text = "Buscar cliente";
            tabPageBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 359);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 44;
            label1.Text = "Endereços ";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.BackgroundColor = Color.SteelBlue;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnIdEnd, clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEnd });
            dgvEnderecos.Location = new Point(23, 377);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(707, 172);
            dgvEnderecos.TabIndex = 43;
            // 
            // clnIdEnd
            // 
            clnIdEnd.HeaderText = "ID";
            clnIdEnd.Name = "clnIdEnd";
            clnIdEnd.ReadOnly = true;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            // 
            // clnTipoEnd
            // 
            clnTipoEnd.HeaderText = "Tipo de Endereço";
            clnTipoEnd.Name = "clnTipoEnd";
            clnTipoEnd.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 12);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 42;
            label7.Text = "Buscar Cliente";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(23, 30);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(707, 23);
            txtBusca.TabIndex = 41;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.BackgroundColor = Color.SteelBlue;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnAtivo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.Location = new Point(23, 59);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(707, 286);
            dgvClientes.TabIndex = 40;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 110;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 140;
            // 
            // clnDataNasc
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            clnDataNasc.DefaultCellStyle = dataGridViewCellStyle5;
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 90;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 45;
            // 
            // tabPageEditar
            // 
            tabPageEditar.Controls.Add(btnCadastrarEnd);
            tabPageEditar.Controls.Add(btnSalvar);
            tabPageEditar.Controls.Add(label6);
            tabPageEditar.Controls.Add(label5);
            tabPageEditar.Controls.Add(label4);
            tabPageEditar.Controls.Add(label3);
            tabPageEditar.Controls.Add(label2);
            tabPageEditar.Controls.Add(label8);
            tabPageEditar.Controls.Add(dtpDataNasc);
            tabPageEditar.Controls.Add(txtEmail);
            tabPageEditar.Controls.Add(txtTelefone);
            tabPageEditar.Controls.Add(txtCpf);
            tabPageEditar.Controls.Add(txtNome);
            tabPageEditar.Controls.Add(txtId);
            tabPageEditar.Location = new Point(4, 24);
            tabPageEditar.Name = "tabPageEditar";
            tabPageEditar.Padding = new Padding(3);
            tabPageEditar.Size = new Size(756, 567);
            tabPageEditar.TabIndex = 1;
            tabPageEditar.Text = "Editar cadastro";
            tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarEnd
            // 
            btnCadastrarEnd.Enabled = false;
            btnCadastrarEnd.Location = new Point(407, 254);
            btnCadastrarEnd.Name = "btnCadastrarEnd";
            btnCadastrarEnd.Size = new Size(191, 23);
            btnCadastrarEnd.TabIndex = 38;
            btnCadastrarEnd.Text = "&Cadastrar outro endereço";
            btnCadastrarEnd.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(211, 254);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 23);
            btnSalvar.TabIndex = 37;
            btnSalvar.Text = "&Salvar alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(536, 176);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 45;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 176);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 44;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 176);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 43;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 103);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 42;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 103);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 41;
            label2.Text = "Nome Completo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 46);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 40;
            label8.Text = "ID";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(536, 194);
            dtpDataNasc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(135, 23);
            dtpDataNasc.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 34;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(332, 194);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 35;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(470, 121);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(166, 23);
            txtCpf.TabIndex = 33;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 121);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 32;
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 64);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 39;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(776, 606);
            Controls.Add(groupBox1);
            Name = "FrmConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaCliente";
            Load += FrmConsultaCliente_Load;
            groupBox1.ResumeLayout(false);
            tabConsultaCliente.ResumeLayout(false);
            tabPageBuscar.ResumeLayout(false);
            tabPageBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabPageEditar.ResumeLayout(false);
            tabPageEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TabControl tabConsultaCliente;
        private TabPage tabPageBuscar;
        private TabPage tabPageEditar;
        private Label label7;
        private TextBox txtBusca;
        private DataGridView dgvClientes;
        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewCheckBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnIdEnd;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEnd;
        private Label label1;
        private Button btnCadastrarEnd;
        private Button btnSalvar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private DateTimePicker dtpDataNasc;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtId;
    }
}