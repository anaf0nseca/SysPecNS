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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            //Obtem lista de clientes
            var lista = Cliente.ObterLista(nome);

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvClientes.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            foreach (var cliente in lista)
            {
                //Adiciona uma nova linha a tabela
                dgvClientes.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[cont].Cells[5].Value = cliente.Data_Nasc;
                dgvClientes.Rows[cont].Cells[6].Value = cliente.Ativo;

                //Soma +1 ao contador de cliente
                cont++;


            }

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Se algo for digitado no campo, o texto é utilizado como parâmetro da classe CarregaGrid
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                //Se nada for digitado, a classe é executada normalmente e exibe todos os clientes
                CarregaGrid();
            }
        }


        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            //Identifica a linha atual(que foi clicada)
            int posicaoLinha = dgvClientes.CurrentRow.Index;

            //Atribui o valor da celula 0 da linha atual(id)
            id = Convert.ToInt32(dgvClientes.Rows[posicaoLinha].Cells[0].Value);


            //MessageBox.Show(id.ToString());

            //Mudar aba ao clicar 2x no cliente desejado 
            this.tabConsultaCliente.SelectedTab = tabPageEditar;


            //Identifica o cliente pelo ID da linha selecionada no DGV
            Cliente cliente1 = Cliente.ObterPorId(id);

            //Preenche os campos com as informações do cliente após obtê-los através do ID
            txtId.Text = cliente1.Id.ToString();
            txtCpf.Text = cliente1.Cpf;
            txtNome.Text = cliente1.Nome;
            txtTelefone.Text = cliente1.Telefone;
            txtEmail.Text = cliente1.Email;

            //Não permite alteração dos campos de CPF e Email que são chaves UNICAS
            txtCpf.ReadOnly = true;
            txtEmail.ReadOnly = true;


        }


        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            //Armazena o número do ID do cliente contido na linha selecionada do GRID, na variavel cliente ID   
            int clienteId = Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value);
            CarregaGridEndereco(clienteId);
        }
        private void CarregaGridEndereco(int clienteId)
        {
            //retorna a lista de endereços associados ao ID do Cliente selecionado
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);

            //Inicia o contador 
            int cont = 0;
            dgvEnderecos.Rows.Clear();

            //Insere os dados de cada endereço associado a esse cliente
            foreach (var endereco in listaEnderecos)
            {
                //Insere uma nova linha na tabela
                int rowIndex = dgvEnderecos.Rows.Add();

                //Associa cada célula da linha a uma informação do endereço
                dgvEnderecos.Rows[cont].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[cont].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[cont].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[cont].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[cont].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[cont].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[cont].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[cont].Cells[7].Value = endereco.Tipo_Endereco;


                //Soma +1 no contador
                cont++;

            }

        }


        private void tabPageEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                Convert.ToInt32(txtId.Text),
                txtNome.Text,
                txtTelefone.Text,
                dtpDataNasc.Value
                );

            cliente.Atualizar();
            MessageBox.Show($"Cadastro do(a) cliente {cliente.Nome} atualizado com sucesso!");

            FrmConsultaCliente_Load(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
