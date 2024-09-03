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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //carregando o combobox de Categorias
            var categorias = Categoria.ObterLista();
            //Carrega a lista de categorias
            cmbCategoria.DataSource = categorias;
            //Exibe o nome da Categoria para o usuario
            cmbCategoria.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID.
            cmbCategoria.ValueMember = "Id";

            CarregaGrid();

        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBarras;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.DataCad;

                cont++;

            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto produto
            Produto produto = new(
                txtCodBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text)
                );

            //Insere os valores no banco
            produto.Inserir();
            if(produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                MessageBox.Show($"Produto gravado com sucesso com o ID: {produto.Id}");

                FrmProduto_Load(sender, e);
            }




        }
    }
}
