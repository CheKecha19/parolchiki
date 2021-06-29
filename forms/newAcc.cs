using System;
using System.Windows.Forms;

namespace parolchiki.forms
{
    public partial class newform : Form
    {
        public newform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка подключения к бд


            if (true)
            {
                //sql запрос на отправку полученных значений

            }
            else
            {
                MessageBox.Show("отсутствует подключение к базе данных");
            }
        }
    }
}
