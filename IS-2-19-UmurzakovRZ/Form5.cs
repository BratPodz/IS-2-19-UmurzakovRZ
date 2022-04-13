using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary7;
using MySql.Data.MySqlClient;

namespace IS_2_19_UmurzakovRZ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection(Con.C());

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public bool InsertStudents(string fiostud, string registration_date)
        {
            int Insert = 0;
            bool result = false;
            conn.Open();
            string query = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fiostud}', '{registration_date}')";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                InsertCount = command.ExecuteNonQuery();
            }
            catch
            {
                Insert = 0;
            }
            finally
            {
                conn.Close();
                if (Insert != 0)
                {
                    result = true;
                }
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Fio_studenta = textBox1.Text;
            string Reg_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!");
            }
            else
            {
                InsertStudents(Fio_studenta, Reg_date);
            }
        }
    }
}
