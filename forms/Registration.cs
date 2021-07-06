using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace parolchiki.forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registrate_Click(object sender, EventArgs e)
        {
            string rname = regname.Text;
            string rlog = reglog.Text;
            string rpass = regpass.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `login`, `password`) VALUES (@UN, @UL, @UP)", db.getConnection()); //вставка в БД данных
            command.Parameters.Add("@UN", MySqlDbType.VarChar).Value = rname;
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = rlog;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = rpass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlCommand selectcommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @UL AND `password` = @UP", db.getConnection()); //проверка на наличие новых данных в БД
            selectcommand.Parameters.Add("@UL", MySqlDbType.VarChar).Value = rlog;
            selectcommand.Parameters.Add("@UP", MySqlDbType.VarChar).Value = rpass;

            adapter.SelectCommand = selectcommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)                               //проверяем, успешна ли регистрация
            {
                MessageBox.Show("Регистрация успешна");
                Autorisation autorisation = new Autorisation();
                autorisation.FormClosed += (o, r) => Close();
                autorisation.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Ошибка, пользователь не создан");
                Focus();
            }
        }
    }
}
