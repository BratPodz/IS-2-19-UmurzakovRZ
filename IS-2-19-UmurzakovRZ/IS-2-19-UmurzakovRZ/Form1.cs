using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_UmurzakovRZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Cp<string> c1 = new Cp<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text);
            listBox1.Items.Add(textBox5.Text);
            listBox1.Items.Add(textBox6.Text);
            c1.Display();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Videokarta<string> v1 = new Videokarta<string>(textBox1.Text, textBox2.Text, (textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text);
            listBox1.Items.Add(textBox5.Text);
            listBox1.Items.Add(textBox6.Text);
            v1.Display();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }

    abstract class Komplekt<A>
    {
        public int Price;
        public string Data_vipuska;
        public A Artikul;

        public Komplekt(int price, string data_vipuska, A artikul)
        {
            Price = price;
            Data_vipuska = data_vipuska;
            Artikul = artikul;
        }

        public abstract void Display();
    }

    class Cp<A> : Komplekt<A>
    {
        private string Chastota { get; set; }
        private int Kol_yader { get; set; }
        private int Kol_potokov { get; set; }

        public Cp(string chastota, int kol_yader, int kol_potokov, int price, string data_vipuska, A artikul)
            : base(price, data_vipuska, artikul)
        {
            Chastota = chastota = "4.2";
            Kol_yader = kol_yader = 6;
            Kol_potokov = kol_potokov = 4;
        }

        public override void Display()
        {
            MessageBox.Show($"Частота - {Chastota}\nКоличество ядер - {Kol_yader}\nКоличество потоков - {Kol_potokov}\nЦена - {Price}\nДата выпуска - {Data_vipuska}\nАртикул - {Artikul}");
        }
    }

    class Videokarta<A> : Komplekt<A>
    {
        private string Chastota_gpu { get; set; }
        private string Proizvoditel { get; set; }
        private string Objem_pamyati { get; set; }

        public Videokarta(string chastota_gpu, string proizvoditel, string objem_pamyati, int price, string data_vipuska, A artikul)
            : base(price, data_vipuska, artikul)
        {
            Chastota_gpu = chastota_gpu = "1785 МГц";
            Proizvoditel = proizvoditel = "MSI";
            Objem_pamyati = objem_pamyati = "4 gb";
        }
        public override void Display()
        {
            MessageBox.Show($"Частота GPU - {Chastota_gpu}\nПроизводитель - {Proizvoditel}\nОбъём памяти - {Objem_pamyati}\nЦена - {Price}\nДата выпуска - {Data_vipuska}\nАртикул - {Artikul}");
        }
    }
}
