namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label4 = new Label();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtIdPedido = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            btnFecharPedido = new Button();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            txtSubtotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Location = new Point(12, 49);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(585, 128);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(421, 34);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 60);
            btnInserePedido.TabIndex = 1;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(103, 71);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(61, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 79);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 5;
            label4.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(170, 71);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(187, 23);
            txtCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(103, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(254, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 37);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(textBox1);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBarras);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(12, 183);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(585, 375);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Antique Olive Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(355, 332);
            label10.Name = "label10";
            label10.Size = new Size(98, 24);
            label10.TabIndex = 13;
            label10.Text = "TOTAL R$";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.HideSelection = false;
            textBox1.Location = new Point(460, 326);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 35);
            textBox1.TabIndex = 12;
            textBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(373, 81);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 81);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 10;
            label8.Text = "Qtde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 81);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 81);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 37);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(373, 99);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(80, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(304, 99);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(37, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(207, 99);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(73, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(6, 55);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 0;
            txtCodBarras.Leave += txtCodBarras_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(7, 99);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(177, 23);
            txtDescricao.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(475, 81);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(99, 49);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBarras, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(7, 141);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(572, 171);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 45;
            // 
            // clnCodBarras
            // 
            clnCodBarras.Frozen = true;
            clnCodBarras.HeaderText = "Cod. Barras";
            clnCodBarras.Name = "clnCodBarras";
            clnCodBarras.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 135;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit.";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 85;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Qtde";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 45;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 80;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Antique Olive Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 19);
            label1.Name = "label1";
            label1.Size = new Size(149, 26);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(634, 12);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(100, 39);
            txtIdPedido.TabIndex = 0;
            txtIdPedido.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Antique Olive Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(596, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 24);
            label2.TabIndex = 4;
            label2.Text = "Nº";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(613, 467);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(131, 29);
            textBox2.TabIndex = 5;
            textBox2.TabStop = false;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.Enabled = false;
            btnFecharPedido.Location = new Point(625, 502);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(100, 43);
            btnFecharPedido.TabIndex = 2;
            btnFecharPedido.Text = "&Fechar Pedido";
            btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Enabled = false;
            txtDescontoPedido.Location = new Point(612, 422);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(132, 23);
            txtDescontoPedido.TabIndex = 1;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(613, 374);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(132, 23);
            txtDescontoItens.TabIndex = 7;
            txtDescontoItens.TabStop = false;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(612, 324);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(132, 23);
            txtSubtotal.TabIndex = 0;
            txtSubtotal.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(612, 306);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 9;
            label11.Text = "Subtotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(613, 356);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 9;
            label12.Text = "Desconto Itens R$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(612, 404);
            label13.Name = "label13";
            label13.Size = new Size(113, 15);
            label13.TabIndex = 9;
            label13.Text = "Desconto Pedido R$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(613, 449);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 9;
            label14.Text = "Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 570);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubtotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoPedido);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtIdPedido);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Controls.Add(btnFecharPedido);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPedidoNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label1;
        private TextBox txtIdPedido;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtCliente;
        private Label label4;
        private Button btnInserePedido;
        private TextBox txtIdCliente;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnFecharPedido;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private TextBox txtSubtotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}