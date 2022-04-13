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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string s= $"SELECT idStud, fioStud, drStud FROM t_datetime";
            try
            {
                conn.Open();
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(s, conn);
                DataSet dataset = new DataSet();
                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
            finally
            {
                conn.Close();
            }

        }

        MySqlConnection conn = new MySqlConnection(Con.C());

        string id = "0";

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;

                string index;
                index = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id = dataGridView1.Rows[Convert.ToInt32(index)].Cells[2].Value.ToString();
                DateTime todays_date = DateTime.Today;
                DateTime Date_of_Birth = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index)].Cells[2].Value.ToString());
                string result = (todays_date - Date_of_Birth).ToString();
                MessageBox.Show("Со дня рождения прошло " + result.Substring(0, result.Length - 9) + " дней");
            }
        }
    }
}
 