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
    }
}
