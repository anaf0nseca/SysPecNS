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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            //Indica que o container pai é o container atual (FrmPrincipal)
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

            //frmUsuario.ShowDialog(); Impede que qualquer outra ação seja executada, a janela em questão fica em primeiro e único plano.


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Texto da mensagem, titulo da caixa, botões exibidos, icone da caixa, botão padrão
            var msg = MessageBox.Show("Deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
            {
                //o par de chaves não é necessário se existe apenas uma linha de código dentro do IF, melhora desempenho
                Application.Exit();
            }
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new FrmConsultaCliente();
            frmConsultaCliente.MdiParent = this;
            frmConsultaCliente.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.StartPosition = FormStartPosition.CenterScreen;
            frmProduto.Show();
        }
    }
}
