using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMetroListView
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsLoadBtn_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var list = db.Products.ToList();
                foreach(Products p in list)
                {
                    ListViewItem item = new ListViewItem(p.ProductID.ToString());
                    item.SubItems.Add(p.ProductName);
                    item.SubItems.Add(p.UnitPrice.ToString());
                    item.SubItems.Add(p.UnitsInStock.ToString());
                    productsListView.Items.Add(item);
                }
            }
        }
    }
}
