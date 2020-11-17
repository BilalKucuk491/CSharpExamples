using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAraclar frmAraclar = new frmAraclar();
            frmAraclar.ShowDialog();
            
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriler frmMusteriler = new frmMusteriler();
            frmMusteriler.ShowDialog();
        }
    }
}
