using Org.BouncyCastle.Crypto.Parameters;
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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            //var fornecedores = Fornecedor.ObterLista();
            btnEditar.Enabled = false;

            CarregaGrid();
            txtRazaoSocial.Focus();



        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Fornecedor.ObterLista();
            dgvFornecedores.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvFornecedores.Rows.Add();
                dgvFornecedores.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvFornecedores.Rows[cont].Cells[1].Value = fornecedor.RazaoSocial;
                dgvFornecedores.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvFornecedores.Rows[cont].Cells[3].Value = fornecedor.Cnpj;
                dgvFornecedores.Rows[cont].Cells[4].Value = fornecedor.Contato;
                dgvFornecedores.Rows[cont].Cells[5].Value = fornecedor.Telefone;
                dgvFornecedores.Rows[cont].Cells[6].Value = fornecedor.Email;
                cont++;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );

            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                txtId.Text = fornecedor.Id.ToString();
                MessageBox.Show($"Fornecedor {fornecedor.RazaoSocial} gravado com sucesso");

                FrmFornecedor_Load(sender, e);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                int.Parse(txtId.Text),
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );

            fornecedor.Atualizar();
            MessageBox.Show($"Fornecedor {fornecedor.RazaoSocial} atualizado com sucesso!");
            btnEditar.Enabled = true;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";

            LimpaControles();
            txtRazaoSocial.Focus();

            FrmFornecedor_Load(sender, e);

        }

        private void LimpaControles()
        {
            txtRazaoSocial.Clear();
            txtFantasia.Clear();
            txtCnpj.Clear();
            txtContato.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
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
                    Fornecedor fornecedor = Fornecedor.ObterPorId(int.Parse(txtId.Text));
                    txtRazaoSocial.Text = fornecedor.RazaoSocial;
                    txtFantasia.Text = fornecedor.Fantasia;
                    txtCnpj.Text = fornecedor.Cnpj;
                    txtContato.Text = fornecedor.Contato;
                    txtTelefone.Text = fornecedor.Telefone;
                    txtEmail.Text = fornecedor.Email;
                    btnEditar.Enabled = true;

                }
            }
        }
    }

}
