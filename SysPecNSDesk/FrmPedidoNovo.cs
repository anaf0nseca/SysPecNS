using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmPedidoNovo : Form
    {
        //public int ClienteId { get; set; }
        //public string NomeCliente { get; set; }


        //inicializa o objeto
        Produto produto;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true;
            grbIdentificacao.Enabled = false;
            btnFecharPedido.Enabled = true;
            txtDescontoPedido.Enabled = true;
            txtCodBarras.Focus();


        }

        private void PreencheGridItens(int idPedido = 0)
        {
            //Obtem lista de clientes
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvItensPedido.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            double desconto = 0;
            double total = 0;
            foreach (var item in itens)
            {
                //Adiciona uma nova linha a tabela
                dgvItensPedido.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvItensPedido.Rows[cont].Cells[0].Value = $"#{cont + 1}";
                dgvItensPedido.Rows[cont].Cells[1].Value = item.Produto.CodBarras;
                dgvItensPedido.Rows[cont].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[cont].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[cont].Cells[4].Value = item.Quantidade.ToString("#0.000");
                dgvItensPedido.Rows[cont].Cells[5].Value = item.Desconto.ToString("#0.00");
                dgvItensPedido.Rows[cont].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");

                //Soma +1 ao contador de cliente
                cont++;
                total += (item.ValorUnit * item.Quantidade) - item.Desconto;
                desconto += item.Desconto;

            }

            textBox1.Text = total.ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");
            txtSubtotal.Text = (total + desconto).ToString("#0.00");
            txtTotal.Text = total.ToString("#0.00");
            //txtDescontoPedido.Text = ;

        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {

            //Se houver um texto digitado no campo do Código de Barras
            if (txtCodBarras.TextLength > 0)
            {
                //objeto produto foi criado anteriormente, mas não foi preenchido
                //Procura um produto na lista que possui o código de barras igual ao que foi digitado no campo 
                produto = Produto.ObterPorId(txtCodBarras.Text);
                //Caso o código de barras exista, preenche os campos do formulário com seus respectivos valores
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();

                lblMaxDesconto.Visible = true;
                //Se a classe de desconto do produto for igual a zero, a caixa de texto para inserir um desconto no item é desabilitado
                if (produto.ClasseDesconto == 0)
                {
                    txtDescontoItem.Enabled = false;
                }
                else
                {

                    txtDescontoItem.Enabled = true;
                    lblMaxDesconto.Text = "R$ " + (produto.ValorUnit * produto.ClasseDesconto).ToString("#0.00");


                }
                //Após o campo do valor unitário ser preenchido pelo sistema, o valor não pode ser alterado pelo usuário
                txtValorUnit.ReadOnly = true;
                //O campo de quantidade recebe o foco para ser preenchido manualmente
                txtQuantidade.Focus();



            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Converte o valor inserido no campo de desconto do item para double
            double descontoItem = Convert.ToDouble(txtDescontoItem.Text);
            //compara o valor de desconto do item com o valor máximo permitido
            if (descontoItem > (produto.ValorUnit * produto.ClasseDesconto))
            {
                MessageBox.Show("Não é possível aplicar esse valor de desconto!");
            }
            else
            {

                ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );

                item.Inserir();
                PreencheGridItens();


                //cria uma instância vazia para limpar as informações, pois o produto já terá sido adicionado no pedido

                //Limpa os campos
                txtQuantidade.Text = "1";
                txtDescontoItem.Text = "0";
                txtDescontoPedido.Text = "0";
                txtCodBarras.Clear();
                txtDescricao.Clear();
                txtValorUnit.Clear();

                txtCodBarras.Focus();

                produto = new();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Cria uma nova instância do Formulário de Busca
            FrmBuscaCliente frmBuscaCliente = new FrmBuscaCliente();
            //Exibe o formulário
            frmBuscaCliente.ShowDialog();

            //Associa o valor da propriedade da tabela de busca a variavel ClienteId
            int clienteId = frmBuscaCliente.ClienteId;

            //Associa o valor da propriedade da tabela de busca a variavel NomeCliente
            string nomeCliente = frmBuscaCliente.NomeCliente;

            //Preenche os campos com as respectivas informações do cliente
            txtIdCliente.Text = clienteId.ToString();
            txtCliente.Text = nomeCliente;
        }

       

        private void txtDescontoPedido_TextChanged(object sender, EventArgs e)
        {
            //Se for inserido um desconto no total do pedido, a caixa de testo 
            if (txtDescontoPedido.Text != string.Empty)
            {

                double total = double.Parse(txtSubtotal.Text) - double.Parse(txtDescontoPedido.Text) - double.Parse(txtDescontoItens.Text);
                txtTotal.Text = total.ToString("#0.00");
            }
            else
            {
                txtDescontoPedido.Text = "0,00";
            }
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            string status = "F";
            string desconto = txtTotal.Text;
            desconto = desconto.Replace(',', '.');
          
            Pedido pedido = new(
                Convert.ToInt32(txtIdPedido.Text),
                Convert.ToString(status),
                double.Parse(txtTotal.Text)

               );

            pedido.AlterarStatus(Convert.ToInt32(txtIdPedido.Text), status);
            pedido.AtualizarDesconto(Convert.ToInt32(txtIdPedido.Text), double.Parse(desconto));

            Close();
        }
    }
}