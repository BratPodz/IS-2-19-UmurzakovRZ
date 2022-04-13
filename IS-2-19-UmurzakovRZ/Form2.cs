using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_2_19_UmurzakovRZ
{
    public partial class Form2 : Form
    {
        class Connect
        {
            public static string Co()
            {
                string Host = "caseum.ru";
                int Port = 33333;
                string User = "test_user";
                string Db = "db_test";
                string Pass = "test_pass";
                string connStr = $"server={Host};" +
                $"port={Port};" +
                $"user={User};" +
                $"database={Db};" +
                $"password={Pass};";
                return connStr;
            }
        }
        public Form2()
        {
           InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(Connect.Co());

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                MessageBox.Show("Подключение");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                MessageBox.Show($"Вы успешно подключены!");
            }
            conn.Close();
        }
    }
}
