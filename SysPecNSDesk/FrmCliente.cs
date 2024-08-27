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
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto cliente
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpDataNasc.Value,
                DateTime.Now,
                chkAtivo.Checked
                );

            cliente.Inserir();
            if (cliente.Id > 0)
            {
                //Exibe ID do cliente no formulário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, " + $"foi inserido com sucesso, com o ID {cliente.Id}");

                //Limpa as informações do formulário
                txtId.Clear();
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

        //private void 

    }
}
