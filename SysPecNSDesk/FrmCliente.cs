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
    public partial class FrmCliente : Form
    {
        public int ClienteId { get; set; }

        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpDataNasc.Value,
                DateTime.Now
                );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " + $"foi inserido com sucesso com o ID {cliente.Id}!");

                btnCadastrarEnd.Enabled = true;
                btnAdicionarEndereco.Enabled = false;

                //Limpa as informações do formulário
                //txtId.Clear();
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();

                //Foca o cursor no campo Nome para a nova inserção
                txtNome.Focus();
                //Recarrega a tabela do formulário para exibir o novo usuário na lista
                FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o cliente no sistema.");
            }

        }


        //private void CarregaGrid(string nome = "")
        //{
        //    //Obtem lista de clientes
        //    var lista = Cliente.ObterLista(nome);

        //    //Limpa as linhas da tabela antes de consultar as informações de cada campo
        //    dgvClientes.Rows.Clear();
        //    //contador para alterar o índice a cada cliente da lista
        //    int cont = 0;
        //    foreach (var cliente in lista)
        //    {
        //        //Adiciona uma nova linha a tabela
        //        dgvClientes.Rows.Add();

        //        //Preenche a linha com as colunas e seus respectivos dados
        //        dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
        //        dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
        //        dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
        //        dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
        //        dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
        //        dgvClientes.Rows[cont].Cells[5].Value = cliente.Data_Nasc;
        //        dgvClientes.Rows[cont].Cells[6].Value = cliente.Ativo;

        //        //Soma +1 ao contador de cliente
        //        cont++;


        //    }

        //}

        //private void txtBusca_TextChanged(object sender, EventArgs e)
        //{
        //    //Se algo for digitado no campo, o texto é utilizado como parâmetro da classe CarregaGrid
        //    if (txtBusca.Text.Length > 0)
        //    {
        //        CarregaGrid(txtBusca.Text);
        //    }
        //    else
        //    {
        //        //Se nada for digitado, a classe é executada normalmente e exibe todos os clientes
        //        CarregaGrid();
        //    }
        //}


        private void btnCadastrarEnd_Click(object sender, EventArgs e)
        {
            this.tabCliente.SelectedTab = tabPageEnderecos;
            ClienteId = int.Parse(txtId.Text);


        }

        private void cmbTipoEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarEndereco_Click_1(object sender, EventArgs e)
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
                cmbTipoEndereco.Text



               );

            endereco.Inserir();
            if (endereco.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.

                MessageBox.Show($"O endereço foi inserido com sucesso, no cadastro do usuário {endereco.Cliente.Nome}");
                
                txtCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();

                btnAdicionarEndereco.Enabled = true;

                btnSalvarEndereco.Enabled = false;



            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o endereço no sistema.");
            }
        }

        private void btnAdicionarEndereco_Click_1(object sender, EventArgs e)
        {

            btnSalvarEndereco.Enabled = true;
            btnAdicionarEndereco.Enabled = false;


            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();

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
               cmbTipoEndereco.Text



              );
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //frmCliente.txtId.Text.Clear();
        }

        
    }
}
