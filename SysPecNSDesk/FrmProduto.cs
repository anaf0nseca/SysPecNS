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
    //Herança
    //partial: indica que uma classe está dividida em vários arquivos
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
            btnEditar.Enabled = false;


            CarregaGrid();

        }

        private void CarregaGrid(string descricao = "")
        {
            var lista = Produto.ObterLista(descricao);
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
            if (produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                MessageBox.Show($"Produto gravado com sucesso com o ID: {produto.Id}");

                FrmProduto_Load(sender, e);
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtId.Text),
                txtCodBarras.Text, txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)(npEstoqueMinimo.Value),
                double.Parse(txtDesconto.Text),
                null,
                null
                );

            produto.Atualizar(); //Grava as alterações no banco
            MessageBox.Show($"Produto {produto.Id} - {produto.Descricao} atualizado com sucesso!");

            btnEditar.Enabled = true;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";


            LimpaControles();
            txtCodBarras.Focus();

            FrmProduto_Load(sender, e);


        }

        private void LimpaControles()
        {
            txtId.Clear();
            txtCodBarras.Clear();
            txtValorUnit.Clear();
            txtUnidadeVenda.Clear();
            txtDescricao.Clear();
            txtDesconto.Clear();
            npEstoqueMinimo.Value = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                LimpaControles();

                btnConsultar.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;

            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtCodBarras.Text = produto.CodBarras;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    //npEstoqueMinimo.Value = produto.EstoqueMinimo;
                    cmbCategoria.SelectedIndex =
                        cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }
        }

    }
}
