﻿using SysPecNSLib;
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


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                
                );
        }
    }
}
