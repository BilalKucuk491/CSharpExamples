using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gorsel2.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void baglan()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        public void verilerigetir()
        {
            try
            {

                baglan();
                komut.CommandText = "select*from Adresler";
                OleDbDataAdapter verial = new OleDbDataAdapter();
                verial.SelectCommand = komut;
                ds.Clear();
                verial.Fill(ds, "Adresler");
                dGridAdresler.DataSource = ds.Tables["Adresler"];
                con.Close();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Hata", hata.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=AdresDefteri.mdb";
            komut.Connection = con;
            verilerigetir();

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            komut.CommandText = "insert into Adresler(tcNo,Ad,Soyad,Adres) values('" + txtTcNo.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtAdres.Text + "')";
            baglan();
            if (komut.ExecuteNonQuery() == 1)
                MessageBox.Show("Kayıt Eklendi");
            else
                MessageBox.Show("Kayıt Eklenmedi");
            con.Close();
            verilerigetir();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            komut.CommandText = "Delete from Adresler where TcNo='" + txtTcNo.Text + "'";
            baglan();
            if (komut.ExecuteNonQuery() == 1)
                MessageBox.Show("Kayıt Silindi");
            else
                MessageBox.Show("Kayıt Silinmedi");
            con.Close();
            verilerigetir();

        }
    }
}
