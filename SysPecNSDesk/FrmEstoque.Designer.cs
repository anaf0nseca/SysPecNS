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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtUnidadeVenda = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescricao = new TextBox();
            txtCodBarras = new TextBox();
            txtId = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
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
            dgvProdutos.Location = new Point(12, 12);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.ScrollBars = ScrollBars.Horizontal;
            dgvProdutos.Size = new Size(673, 332);
            dgvProdutos.TabIndex = 9;
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
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            clnValorUnitario.DefaultCellStyle = dataGridViewCellStyle3;
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
            gpEstoque.Controls.Add(textBox3);
            gpEstoque.Controls.Add(button1);
            gpEstoque.Controls.Add(label3);
            gpEstoque.Controls.Add(textBox2);
            gpEstoque.Controls.Add(label4);
            gpEstoque.Controls.Add(txtUnidadeVenda);
            gpEstoque.Controls.Add(label5);
            gpEstoque.Controls.Add(textBox1);
            gpEstoque.Controls.Add(label6);
            gpEstoque.Controls.Add(label2);
            gpEstoque.Controls.Add(label1);
            gpEstoque.Controls.Add(txtDescricao);
            gpEstoque.Controls.Add(txtCodBarras);
            gpEstoque.Controls.Add(txtId);
            gpEstoque.Location = new Point(12, 365);
            gpEstoque.Name = "gpEstoque";
            gpEstoque.Size = new Size(673, 212);
            gpEstoque.TabIndex = 10;
            gpEstoque.TabStop = false;
            gpEstoque.Text = "Entrada em Estoque";
            // 
            // button1
            // 
            button1.Location = new Point(505, 157);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 36;
            button1.Text = "&Inserir";
            button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(372, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 23);
            textBox2.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(505, 92);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 33;
            label4.Text = "Unidade de Venda";
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtUnidadeVenda.Location = new Point(505, 110);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.ReadOnly = true;
            txtUnidadeVenda.Size = new Size(131, 23);
            txtUnidadeVenda.TabIndex = 32;
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
            // textBox1
            // 
            textBox1.Location = new Point(22, 167);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(199, 92);
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
            txtDescricao.Location = new Point(201, 110);
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
            // 
            // txtId
            // 
            txtId.Location = new Point(23, 53);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 167);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 37;
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
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 588);
            Controls.Add(gpEstoque);
            Controls.Add(dgvProdutos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstoque";
            Text = "Estoque de Produtos";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            gpEstoque.ResumeLayout(false);
            gpEstoque.PerformLayout();
            ResumeLayout(false);
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
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtUnidadeVenda;
        private Button button1;
        private Label label3;
        private Label label7;
        private TextBox textBox3;
    }
}