using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtons
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            /*
             
            int x = 22, y = 22;
            
            for (int j = 1; j < masa_kapasite; j++)
            {
                if (j == 1)
                {
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Name = "btnMasa" + j.ToString();
                    btn.Text = "M" + j.ToString();
                    btn.Size = new Size(100, 100);
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Segoe UI", 20);
                    this.Controls.Add(btn);
                }
                else if (j <= 36 && j > 1 && j != 9 && j != 17 && j != 25 && j!=33)
                {
                    x = x + 104;
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Name = "btnMasa" + j.ToString();
                    btn.Text = "M" + j.ToString();
                    btn.Size = new Size(100, 100);
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Segoe UI", 20);
                    this.Controls.Add(btn);
                }
                else
                {
                    x= 22;
                    y = y + 106;
                    Button btn = new Button();
                    btn.Location = new Point(x, y);
                    btn.Name = "btnMasa" + j.ToString();
                    btn.Text = "M" + j.ToString();
                    btn.Size = new Size(100, 100);
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Segoe UI", 20);
                    this.Controls.Add(btn);
                }
                
               
            }
             
             
             */

        }

        int masa_kapasite = 33;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (masa_kapasite <= 33)
            {
                int x = 22, y = 22;
                for (int j = 1; j < masa_kapasite; j++)
                {
                    if (j == 1)
                    {
                        Button btn = new Button();
                        btn.Location = new Point(x, y);
                        btn.Name = "btnMasa" + j.ToString();
                        btn.Text = "M" + j.ToString();
                        btn.Size = new Size(100, 100);
                        btn.BackColor = Color.White;
                        btn.Font = new Font("Segoe UI", 20);
                        this.Controls.Add(btn);
                    }
                    else if (j <= 32 && j > 1 && j != 9 && j != 17 && j != 25)
                    {
                        x = x + 104;
                        Button btn = new Button();
                        btn.Location = new Point(x, y);
                        btn.Name = "btnMasa" + j.ToString();
                        btn.Text = "M" + j.ToString();
                        btn.Size = new Size(100, 100);
                        btn.BackColor = Color.White;
                        btn.Font = new Font("Segoe UI", 20);
                        this.Controls.Add(btn);
                    }
                    else
                    {
                        x = 22;
                        y = y + 106;
                        Button btn = new Button();
                        btn.Location = new Point(x, y);
                        btn.Name = "btnMasa" + j.ToString();
                        btn.Text = "M" + j.ToString();
                        btn.Size = new Size(100, 100);
                        btn.BackColor = Color.White;
                        btn.Font = new Font("Segoe UI", 20);
                        this.Controls.Add(btn);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hata masa kapasitesini aştınız.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


