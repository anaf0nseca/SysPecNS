namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            gpEstoque = new GroupBox();
            label7 = new Label();
            txtDisponivelEstoque = new TextBox();
            btnInserirEntrada = new Button();
            label3 = new Label();
            txtEntradaEstoque = new TextBox();
            label4 = new Label();
            txtUnidadeVenda = new TextBox();
            label5 = new Label();
            txtEstoqueMin = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodBarras = new TextBox();
            txtId = new TextBox();
            btnCancelar = new Button();
            txtBusca = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            gpEstoque.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.BackgroundColor = Color.FromArgb(29, 96, 150);
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoBarras, clnDescricao, clnValorUnitario, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDataCadastro });
            dgvProdutos.Location = new Point(13, 53);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(673, 332);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
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
            // gpEstoque
            // 
            gpEstoque.Controls.Add(label7);
            gpEstoque.Controls.Add(txtDisponivelEstoque);
            gpEstoque.Controls.Add(btnInserirEntrada);
            gpEstoque.Controls.Add(label3);
            gpEstoque.Controls.Add(txtEntradaEstoque);
            gpEstoque.Controls.Add(label4);
            gpEstoque.Controls.Add(txtUnidadeVenda);
            gpEstoque.Controls.Add(label5);
            gpEstoque.Controls.Add(txtEstoqueMin);
            gpEstoque.Controls.Add(label6);
            gpEstoque.Controls.Add(label2);
            gpEstoque.Controls.Add(label1);
            gpEstoque.Controls.Add(txtDescricao);
            gpEstoque.Controls.Add(txtCodBarras);
            gpEstoque.Controls.Add(txtId);
            gpEstoque.Enabled = false;
            gpEstoque.Location = new Point(13, 404);
            gpEstoque.Name = "gpEstoque";
            gpEstoque.Size = new Size(636, 212);
            gpEstoque.TabIndex = 10;
            gpEstoque.TabStop = false;
            gpEstoque.Text = "Entrada em Estoque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(199, 149);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 38;
            label7.Text = "Disponível em estoque";
            // 
            // txtDisponivelEstoque
            // 
            txtDisponivelEstoque.Location = new Point(199, 167);
            txtDisponivelEstoque.Name = "txtDisponivelEstoque";
            txtDisponivelEstoque.ReadOnly = true;
            txtDisponivelEstoque.Size = new Size(128, 23);
            txtDisponivelEstoque.TabIndex = 37;
            txtDisponivelEstoque.TextAlign = HorizontalAlignment.Right;
            // 
            // btnInserirEntrada
            // 
            btnInserirEntrada.Location = new Point(505, 157);
            btnInserirEntrada.Name = "btnInserirEntrada";
            btnInserirEntrada.Size = new Size(104, 40);
            btnInserirEntrada.TabIndex = 36;
            btnInserirEntrada.Text = "&Inserir";
            btnInserirEntrada.UseVisualStyleBackColor = true;
            btnInserirEntrada.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(372, 149);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 35;
            label3.Text = "Entrada";
            // 
            // txtEntradaEstoque
            // 
            txtEntradaEstoque.Location = new Point(372, 167);
            txtEntradaEstoque.Name = "txtEntradaEstoque";
            txtEntradaEstoque.Size = new Size(86, 23);
            txtEntradaEstoque.TabIndex = 34;
            txtEntradaEstoque.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(490, 92);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 33;
            label4.Text = "Unidade de Venda";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtUnidadeVenda.Location = new Point(490, 110);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.ReadOnly = true;
            txtUnidadeVenda.Size = new Size(131, 23);
            txtUnidadeVenda.TabIndex = 32;
            txtUnidadeVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(22, 149);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 31;
            label5.Text = "Estoque Mínimo";
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(22, 167);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new Size(128, 23);
            txtEstoqueMin.TabIndex = 30;
            txtEstoqueMin.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(188, 92);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 29;
            label6.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 28;
            label2.Text = "Código de Barras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtDescricao.Location = new Point(190, 110);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(268, 23);
            txtDescricao.TabIndex = 25;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtCodBarras.Location = new Point(22, 110);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.ReadOnly = true;
            txtCodBarras.Size = new Size(142, 23);
            txtCodBarras.TabIndex = 24;
            txtCodBarras.TextAlign = HorizontalAlignment.Right;
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 53);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(655, 571);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(40, 45);
            btnCancelar.TabIndex = 39;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 24);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(674, 23);
            txtBusca.TabIndex = 42;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 6);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 39;
            label8.Text = "Buscar produto";
            // 
            // FrmEstoque
            // 
            AcceptButton = btnInserirEntrada;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(698, 628);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(txtBusca);
            Controls.Add(gpEstoque);
            Controls.Add(dgvProdutos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque de Produtos";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            gpEstoque.ResumeLayout(false);
            gpEstoque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCadastro;
        private GroupBox gpEstoque;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txtDescricao;
        private TextBox txtCodBarras;
        private TextBox txtId;
        private TextBox txtEstoqueMin;
        private Label label5;
        private TextBox txtEntradaEstoque;
        private Label label4;
        private TextBox txtUnidadeVenda;
        private Button btnInserirEntrada;
        private Label label3;
        private Label label7;
        private TextBox txtDisponivelEstoque;
        private TextBox txtBusca;
        private Label label8;
        private Button btnCancelar;
    }
}