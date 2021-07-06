using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parolchiki.forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DB db = new DB();
            db.openconnection();
            // db.regetaccounts();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM accounts ORDER BY site", db.getConnection());

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            db.closeconnection();
            foreach(string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }



        }

        private void wikiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            HELP help = new HELP();
            help.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("(C) Nikita Nazarov\nspecial to TOMIAC\n2021\nnazarov.nekit@mail.ru\nlicensed by MiT. i think so...");
        }

        private void проверкаПодключенияToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            db.regetaccounts();
        }

        private void добавитьНовыйАккаунтToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            newform newform = new newform();
            newform.Show();
            newform.Focus();
        }

        private void очиститьБДToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DB db = new DB();
            db.openconnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            {
                //
                // очистка таблицы с аккаунтами
                //

                MySqlCommand command = new MySqlCommand("", db.getConnection());
            }
        }
    }
}
