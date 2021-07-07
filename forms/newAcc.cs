using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            MainForm main = new MainForm();
            main.FormClosed += (o, r) => Close();
            main.Show();
            main.refreshdatabase();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openconnection();

            // отправка данных в БД
            {
                String
                    //name = "User", //добавить хуйню для ввода в БД имени пользователя
                    acclogin = textBox1.Text,
                    accpassword = textBox2.Text,
                    accsite = textBox3.Text,
                    accphone = textBox4.Text,
                    accemail = textBox5.Text,
                    accothers = richTextBox1.Text;

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `accounts` (`Login`, `Password`, `Site`, `Phone`, `Email`, `Others`) VALUES (@UL, @UP, @US, @UPH, @UM, @UO)", db.getConnection());
                    //command.Parameters.Add("@UN", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = acclogin;
                    command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = accpassword;
                    command.Parameters.Add("@US", MySqlDbType.VarChar).Value = accsite;
                    command.Parameters.Add("@UPH", MySqlDbType.VarChar).Value = accphone;
                    command.Parameters.Add("@UM", MySqlDbType.VarChar).Value = accemail;
                    command.Parameters.Add("@UO", MySqlDbType.VarChar).Value = accothers;

                    adapter.SelectCommand = command;
                    MainForm main = new MainForm();
                    main.refreshdatabase();
                    adapter.Fill(table);
                    db.closeconnection();
                }

                Close();
            }
        }
    }
}
