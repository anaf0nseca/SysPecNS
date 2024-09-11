namespace SysPecNSDesk
{
    partial class FrmProduto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gpProdutos = new GroupBox();
            npEstoqueMinimo = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            cmbCategoria = new ComboBox();
            txtDesconto = new TextBox();
            txtDescricao = new TextBox();
            txtUnidadeVenda = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            txtId = new TextBox();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigoBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnitario = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCadastro = new DataGridViewTextBoxColumn();
            gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gpProdutos
            // 
            gpProdutos.BackColor = Color.White;
            gpProdutos.Controls.Add(npEstoqueMinimo);
            gpProdutos.Controls.Add(label8);
            gpProdutos.Controls.Add(label7);
            gpProdutos.Controls.Add(label6);
            gpProdutos.Controls.Add(label5);
            gpProdutos.Controls.Add(label4);
            gpProdutos.Controls.Add(label3);
            gpProdutos.Controls.Add(label2);
            gpProdutos.Controls.Add(label1);
            gpProdutos.Controls.Add(btnConsultar);
            gpProdutos.Controls.Add(btnEditar);
            gpProdutos.Controls.Add(btnAdicionar);
            gpProdutos.Controls.Add(cmbCategoria);
            gpProdutos.Controls.Add(txtDesconto);
            gpProdutos.Controls.Add(txtDescricao);
            gpProdutos.Controls.Add(txtUnidadeVenda);
            gpProdutos.Controls.Add(txtValorUnit);
            gpProdutos.Controls.Add(txtCodBarras);
            gpProdutos.Controls.Add(txtId);
            gpProdutos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpProdutos.ForeColor = Color.Black;
            gpProdutos.Location = new Point(12, 12);
            gpProdutos.Name = "gpProdutos";
            gpProdutos.Size = new Size(651, 316);
            gpProdutos.TabIndex = 7;
            gpProdutos.TabStop = false;
            gpProdutos.Text = "Produtos";
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            npEstoqueMinimo.Location = new Point(533, 114);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(65, 23);
            npEstoqueMinimo.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(30, 219);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 25;
            label8.Text = "Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(208, 157);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 24;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(30, 157);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 23;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(533, 96);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 22;
            label5.Text = "Estoque Mínimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(369, 96);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 21;
            label4.Text = "Unidade de Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(208, 96);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 20;
            label3.Text = "Valor Unitário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 19;
            label2.Text = "Código de Barras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 18;
            label1.Text = "ID";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(35, 84, 150);
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Segoe UI", 8.25F);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(500, 239);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(127, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(35, 84, 150);
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 8.25F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(341, 238);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(35, 84, 150);
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI", 8.25F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(190, 238);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(127, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(208, 175);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(359, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtDesconto.Location = new Point(30, 239);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(142, 23);
            txtDesconto.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtDescricao.Location = new Point(30, 175);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(142, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtUnidadeVenda.Location = new Point(369, 114);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Ex: Caixa";
            txtUnidadeVenda.Size = new Size(131, 23);
            txtUnidadeVenda.TabIndex = 2;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtValorUnit.Location = new Point(208, 114);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(127, 23);
            txtValorUnit.TabIndex = 1;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtCodBarras.Location = new Point(30, 114);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(142, 23);
            txtCodBarras.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(30, 56);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 7;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.BackgroundColor = Color.FromArgb(29, 96, 150);
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoBarras, clnDescricao, clnValorUnitario, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDataCadastro });
            dgvProdutos.Location = new Point(13, 334);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.ScrollBars = ScrollBars.Horizontal;
            dgvProdutos.Size = new Size(651, 304);
            dgvProdutos.TabIndex = 8;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnCodigoBarras
            // 
            clnCodigoBarras.HeaderText = "Código de Barras";
            clnCodigoBarras.Name = "clnCodigoBarras";
            clnCodigoBarras.ReadOnly = true;
            clnCodigoBarras.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 150;
            // 
            // clnValorUnitario
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            clnValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            clnValorUnitario.HeaderText = "Valor Unitário";
            clnValorUnitario.Name = "clnValorUnitario";
            clnValorUnitario.ReadOnly = true;
            clnValorUnitario.Width = 80;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 120;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 120;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Mínimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 80;
            // 
            // clnDataCadastro
            // 
            clnDataCadastro.HeaderText = "Data de Cadastro";
            clnDataCadastro.Name = "clnDataCadastro";
            clnDataCadastro.ReadOnly = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(676, 650);
            Controls.Add(dgvProdutos);
            Controls.Add(gpProdutos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProduto";
            Text = "Cadastro de Produto";
            Load += FrmProduto_Load;
            gpProdutos.ResumeLayout(false);
            gpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpProdutos;
        private ComboBox cmbCategoria;
        private TextBox txtDesconto;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorUnit;
        private TextBox txtCodBarras;
        private TextBox txtId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private DataGridView dgvProdutos;
        private NumericUpDown npEstoqueMinimo;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCadastro;
    }
}