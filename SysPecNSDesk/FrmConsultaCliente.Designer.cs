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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            groupBox2 = new GroupBox();
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
            gpbEndereco = new GroupBox();
            btnSalvarEndereco = new Button();
            cmbTipoEndereco = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            txtUf = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            label16 = new Label();
            txtCep = new TextBox();
            groupBox1.SuspendLayout();
            tabConsultaCliente.SuspendLayout();
            tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPageEditar.SuspendLayout();
            groupBox2.SuspendLayout();
            gpbEndereco.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            clnDataNasc.DefaultCellStyle = dataGridViewCellStyle1;
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
            tabPageEditar.Controls.Add(groupBox2);
            tabPageEditar.Controls.Add(gpbEndereco);
            tabPageEditar.Location = new Point(4, 24);
            tabPageEditar.Name = "tabPageEditar";
            tabPageEditar.Padding = new Padding(3);
            tabPageEditar.Size = new Size(756, 567);
            tabPageEditar.TabIndex = 1;
            tabPageEditar.Text = "Editar cadastro";
            tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCadastrarEnd);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpDataNasc);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtTelefone);
            groupBox2.Controls.Add(txtCpf);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(txtId);
            groupBox2.Location = new Point(48, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 255);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnCadastrarEnd
            // 
            btnCadastrarEnd.Location = new Point(325, 211);
            btnCadastrarEnd.Name = "btnCadastrarEnd";
            btnCadastrarEnd.Size = new Size(191, 23);
            btnCadastrarEnd.TabIndex = 52;
            btnCadastrarEnd.Text = "&Cadastrar outro endereço";
            btnCadastrarEnd.UseVisualStyleBackColor = true;
            btnCadastrarEnd.Click += btnCadastrarEnd_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(129, 211);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 23);
            btnSalvar.TabIndex = 51;
            btnSalvar.Text = "&Salvar alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 151);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 59;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 151);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 58;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 151);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 57;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 78);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 56;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 55;
            label2.Text = "Nome Completo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 21);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 54;
            label8.Text = "ID";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(472, 169);
            dtpDataNasc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(135, 23);
            dtpDataNasc.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 48;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(268, 169);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 23);
            txtTelefone.TabIndex = 49;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(406, 96);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(166, 23);
            txtCpf.TabIndex = 47;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 46;
            // 
            // txtId
            // 
            txtId.Location = new Point(18, 39);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 53;
            // 
            // gpbEndereco
            // 
            gpbEndereco.Controls.Add(btnSalvarEndereco);
            gpbEndereco.Controls.Add(cmbTipoEndereco);
            gpbEndereco.Controls.Add(label14);
            gpbEndereco.Controls.Add(label15);
            gpbEndereco.Controls.Add(txtUf);
            gpbEndereco.Controls.Add(label12);
            gpbEndereco.Controls.Add(label13);
            gpbEndereco.Controls.Add(txtCidade);
            gpbEndereco.Controls.Add(txtBairro);
            gpbEndereco.Controls.Add(label9);
            gpbEndereco.Controls.Add(label10);
            gpbEndereco.Controls.Add(label11);
            gpbEndereco.Controls.Add(txtComplemento);
            gpbEndereco.Controls.Add(txtNumero);
            gpbEndereco.Controls.Add(txtLogradouro);
            gpbEndereco.Controls.Add(label16);
            gpbEndereco.Controls.Add(txtCep);
            gpbEndereco.Enabled = false;
            gpbEndereco.Location = new Point(48, 276);
            gpbEndereco.Name = "gpbEndereco";
            gpbEndereco.Size = new Size(655, 260);
            gpbEndereco.TabIndex = 46;
            gpbEndereco.TabStop = false;
            gpbEndereco.Text = "Adicionar novo endereço";
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.BackColor = Color.FromArgb(35, 84, 150);
            btnSalvarEndereco.FlatStyle = FlatStyle.Flat;
            btnSalvarEndereco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSalvarEndereco.ForeColor = Color.White;
            btnSalvarEndereco.Location = new Point(505, 214);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(102, 23);
            btnSalvarEndereco.TabIndex = 79;
            btnSalvarEndereco.Text = "&Salvar endereço";
            btnSalvarEndereco.UseVisualStyleBackColor = false;
            btnSalvarEndereco.Click += btnSalvarEndereco_Click;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "COS - Correspondência", "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança" });
            cmbTipoEndereco.Location = new Point(344, 214);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(121, 23);
            cmbTipoEndereco.TabIndex = 78;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(344, 196);
            label14.Name = "label14";
            label14.Size = new Size(98, 15);
            label14.TabIndex = 77;
            label14.Text = "Tipo de Endereço";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(253, 196);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 76;
            label15.Text = "UF";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(253, 214);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(63, 23);
            txtUf.TabIndex = 75;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(26, 196);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 74;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(253, 140);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 73;
            label13.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(26, 214);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 72;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(253, 158);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(179, 23);
            txtBairro.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 140);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 70;
            label9.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(452, 85);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 69;
            label10.Text = "Nº";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(26, 85);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 68;
            label11.Text = "Logradouro";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(26, 158);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(161, 23);
            txtComplemento.TabIndex = 67;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(450, 103);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 66;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(26, 103);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(406, 23);
            txtLogradouro.TabIndex = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(26, 27);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 64;
            label16.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(26, 45);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(127, 23);
            txtCep.TabIndex = 63;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(776, 606);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gpbEndereco.ResumeLayout(false);
            gpbEndereco.PerformLayout();
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
        private GroupBox gpbEndereco;
        private Button btnSalvarEndereco;
        private ComboBox cmbTipoEndereco;
        private Label label14;
        private Label label15;
        private TextBox txtUf;
        private Label label12;
        private Label label13;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private Label label16;
        private TextBox txtCep;
        private GroupBox groupBox2;
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