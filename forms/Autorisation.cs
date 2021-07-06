using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace parolchiki.forms
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void Autorisation_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HELP help = new HELP();
            help.Show();
            help.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rlog = textBox1.Text;
            string rpass = textBox2.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand selectcommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @UL AND `password` = @UP", db.getConnection()); //проверка в БД наличия авторизующегося пользователя
            selectcommand.Parameters.Add("@UL", MySqlDbType.VarChar).Value = rlog;
            selectcommand.Parameters.Add("@UP", MySqlDbType.VarChar).Value = rpass;

            adapter.SelectCommand = selectcommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MainForm main = new MainForm();
                main.FormClosed += (o, r) => Close();
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Пользователя не существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.FormClosed += (o, r) => Close();
            registration.Show();
            Hide();
        }
    }
}
