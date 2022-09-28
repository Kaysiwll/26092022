using System.Windows.Forms;

namespace _26092022
{
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btt_Close_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btt_ModificaLabel_Click(object sender, System.EventArgs e)
        {
            lbl_Titulo.Text = "Label Modificada!";
        }

        private void frm_HelloWorld_Load(object sender, System.EventArgs e)
        {

        }

        private void txtConteudoLabel_TextChanged(object sender, System.EventArgs e)
        {
            lbl_Titulo.Text = txtConteudoLabel.Text;
        }
    }
}
