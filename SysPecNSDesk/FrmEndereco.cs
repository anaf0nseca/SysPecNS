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
    public partial class FrmEndereco : Form
    {
        public int ClienteId { get; set; }


        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEndereco_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.ClienteId.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Endereco endereco = new(
                Cliente.ObterPorId(ClienteId),
                txtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                txtUf.Text,
                txtTipoEndereco.Text



               );

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.

                MessageBox.Show($"O endereço foi inserido com sucesso, no cadastro do usuário {endereco.Cliente.Nome}");

                btnSalvarEndereco.Enabled = false;


                //Limpa as informações do formulário
                //txtId.Clear();
                //txtNome.Clear();
                //txtCpf.Clear();
                //txtTelefone.Clear();
                //txtEmail.Clear();

                //Foca o cursor no campo Nome para a nova inserção
                //txtNome.Focus();
                //Recarrega a tabela do formulário para exibir o novo usuário na lista
                //FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o endereço no sistema.");
            }
        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {
            btnSalvarEndereco.Enabled = true;

            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            txtTipoEndereco.Clear();

            txtCep.Focus();

            Endereco endereco = new(
               Cliente.ObterPorId(ClienteId),
               txtCep.Text,
               txtLogradouro.Text,
               txtNumero.Text,
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtUf.Text,
               txtTipoEndereco.Text



              );
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           this.Close();
           //frmCliente.txtId.Text.Clear();
        }
    }
}
