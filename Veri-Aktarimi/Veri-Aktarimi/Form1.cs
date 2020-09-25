
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Aktarimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Veri Aktarimi";
            btn1.Text = "Hesapla";
            errorProvider1.BlinkRate = 350;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            textBox2.MaxLength = 3;
            textBox3.MaxLength = 3;
            textBox4.MaxLength = 3;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.label4.Text = textBox1.Text;
            double y1 = Convert.ToDouble(textBox2.Text);
            double y2 = Convert.ToDouble(textBox3.Text);
            double y3 = Convert.ToDouble(textBox4.Text);
            double ort = (y1 + y2 + y3) / 3;
            f2.label5.Text =ort.ToString();
            if (ort < 55)
            {
                f2.label6.Text = "Kaldiniz";
            }
            else if (ort == 55)
            {
                f2.label6.Text = "Gecer";
            }
            else if (ort > 55 && ort == 65)
            {
                f2.label6.Text = "Vasat";
            }
            else if (ort >= 70 && ort == 80)
            {
                f2.label6.Text = "Iyi";
            }
            else
            {
                f2.label6.Text = "Basarili";
            }
            f2.ShowDialog();

        }

        private void SayiDegisimi_TextChanged(object sender, EventArgs e)
        {
            int i = 101;
            if (textBox2.Text == i.ToString())
            {
                errorProvider1.SetError(textBox2,"Degerleri Duzgun gireleim");
            }
            else if (textBox3.Text == i.ToString())
            {
                errorProvider1.SetError(textBox3, "Degerleri Duzgun gireleim");
            }
            else if (textBox4.Text == i.ToString())
            {
                errorProvider1.SetError(textBox4, "Degerleri Duzgun gireleim");
            }
            else
                errorProvider1.Clear();
        }
    }
}
