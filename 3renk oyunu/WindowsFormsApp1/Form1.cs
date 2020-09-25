using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        int coin = 100;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Money Game";
            btn1.Enabled = false; btn2.Enabled = false; btn3.Enabled = false;
            btn4.Text = "Başla";
            lbl1.Text = "Coin:";
            
        }

        private void DegerYaz()
        {
            lbl4.Text = score.ToString();
            lbl2.Text = coin.ToString();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[4] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
            Random r = new Random();
            int renk_elamani1 = r.Next(0, 4);
            int renk_elamani2 = r.Next(0, 4);
            int renk_elamani3 = r.Next(0, 4);
            btn1.BackColor = renkler[renk_elamani1];
            btn2.BackColor = renkler[renk_elamani2];
            btn3.BackColor = renkler[renk_elamani3];
            if (btn1.BackColor == btn2.BackColor && btn2.BackColor == btn3.BackColor && btn1.BackColor == btn3.BackColor)
            {
                coin = coin + 15;
                score = score + 5;
                DegerYaz();
            }
            else if (btn1.BackColor != btn2.BackColor && btn2.BackColor != btn3.BackColor && btn1.BackColor != btn3.BackColor)
            {
                coin = coin - 5;
                score = score - 1;
                lbl2.Text = coin.ToString();
            }

            if (coin <= 0 || score < 0 )
            {

                lbl3.Text = "GAME OVER";
                coin = 25;
                score = 0;
            }
            else if (coin > 0 && coin < 100)
            {
                lbl3.Text = "";
            }

            if (score >= 100)
            {
                lbl3.Text = "YOU WON";
                coin = 25;
                score = 0;
            }
            else if (score == 0 )
            {
                lbl3.Text = "";
                coin = 25;
                score = 0;
                DegerYaz();
            }
            else if (score < 0)
            {
                lbl3.Text = "";
                coin = 25;
                score = 0;
                DegerYaz();
            }

        }
    }
}
