using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26092022
{
    public partial class frmDemonstracaoKey : Form
    {
        public frmDemonstracaoKey()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            txtMsg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
        }
    }
}
