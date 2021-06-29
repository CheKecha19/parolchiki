using System.Windows.Forms;

namespace parolchiki.forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            HELP help = new HELP();
            help.Show();
        }
    }
}
