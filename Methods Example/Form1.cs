using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HesMak hm = new HesMak();
            hm.mesaj();
            this.Text = Convert.ToString(hm.toplam());
            this.Text = "Methods";
            label1.Text = hm.toplam().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HesMak.duragan();
        }
    }
}
