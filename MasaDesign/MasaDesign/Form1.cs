using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toolSbtnFont_Click(object sender, EventArgs e)
        {
            FontDialog yaziFont = new FontDialog();
            if (yaziFont.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                label1.Font = yaziFont.Font;
                button1.Font = yaziFont.Font;
            }
        }

        private void toolSbtnMasaColor_Click(object sender, EventArgs e)
        {
            ColorDialog renkSec = new ColorDialog();
            if (renkSec.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                button1.BackColor = renkSec.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMGrey_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void toolStripMBlack_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void toolStripMSilver_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void toolSbtnBackColor_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog renkSec = new ColorDialog();
            if (renkSec.ShowDialog() == DialogResult.OK) // colordialog'tan bir renk seçildiyse işlem yapılacak.
            {
                this.BackColor = renkSec.Color;
            }
        }
    }
}
