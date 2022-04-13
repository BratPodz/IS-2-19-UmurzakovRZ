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
using ClassLibrary7;


namespace IS_2_19_UmurzakovRZ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(Con.C());

        string id = "0";


        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();

        public void SelectedRows()
        {
            string index_selected;
            index_selected = dataGridView1.SelectedCells[0].RowIndex.ToString();
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected)].Cells[1].Value.ToString();
            MessageBox.Show(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string s = $"SELECT id, fio, theme_kurs FROM t_stud";
                MyDA.SelectCommand = new MySqlCommand(s, conn);
                MyDA.Fill(table);
                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            SelectedRows();
        }
    }
}
