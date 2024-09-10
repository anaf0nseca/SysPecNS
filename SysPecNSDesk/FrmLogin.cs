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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Caso o formulario de login seja cancelado, a aplicação é encerrada.
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            //Verifica se os campos de email e senha estão preenchidos
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                //chama o método para efetuar login, recebendo o email e a senha e faz a validação
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

                //verifica se o usuário for autenticado e estiver ativo 
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {

                        Program.UsuarioLogado = usuario;

                        //o formulário de login é fechado e é possível ter acesso ao formulário principal
                        Close();

                    }
                    else
                    {
                        //Caso o usuário esteja inativo, a mensagem é exibida e a aplicação é encerrada.
                        MessageBox.Show("Seu usuário está inativo. \n Entre em contato com a gerência.");
                        Application.Exit();
                    }


                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, ou inexistente. \n Entre em contato com a gerência.");
                    txtEmail.Focus();
                }
            }
            else
            {
                //Se o usuário tentar logar sem inserir nenhum dado, a mensagem é exibida
                MessageBox.Show("Você deve inserir seu email e senha para logar no sistema.");
                //o foco volta para a caixa de texto do email
                txtEmail.Focus();
            }

        }//fim evento click do botão logar

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
