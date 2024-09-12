using SysPecNSLib;
namespace SysPecNSDesk

{
    public partial class FrmBuscaCliente : Form
    {
        //Propriedade criada para o ID
        public int ClienteId { get; set; }

        //Propriedade criada para o Nome do Cliente
        public string NomeCliente { get; set; }

        public FrmBuscaCliente()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Olá TI96");
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

        public void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            //Identifica a linha atual(que foi clicada)
            int posicaoLinha = dgvClientes.CurrentRow.Index;

            //Atribui o valor da celula 0 da linha atual(id)
            id = Convert.ToInt32(dgvClientes.Rows[posicaoLinha].Cells[0].Value);
            //string nome = dgvClientes.Rows[posicaoLinha].Cells[1].Value.ToString();

            //Busca o cliente com o ID da linha selecionada
            Cliente cliente = Cliente.ObterPorId(id);

            //Associa o ID do cliente encontrado a propriedade ClienteId
            ClienteId = cliente.Id;

            //Associa o Nome do cliente encontrado a propriedade NomeCliente
            NomeCliente = cliente.Nome;

            Close();

        }
    }
}
