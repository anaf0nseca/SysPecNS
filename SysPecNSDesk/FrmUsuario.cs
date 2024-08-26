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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //carregando o combobox de niveis
            var niveis = Nivel.ObterLista();
            //Carrega a lista de nivel
            cmbNivel.DataSource = niveis;
            //Exibe o nome do nível para o usuario
            cmbNivel.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID.
            cmbNivel.ValueMember = "Id";

            //Preenchendo o datagrid com os usuarios
            var lista = Usuario.ObterLista();
            //Limpar as linhas da tabela
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;

                cont++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
