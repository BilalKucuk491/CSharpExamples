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
            txtTemizle();
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
            txtTemizle();

        }
        private void dGridAdresler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTcNo.Text= dGridAdresler.Rows[SeciliSatir].Cells[1].Value.ToString();
            txtAd.Text = dGridAdresler.Rows[SeciliSatir].Cells[2].Value.ToString();
            txtSoyad.Text = dGridAdresler.Rows[SeciliSatir].Cells[3].Value.ToString();
            txtAdres.Text = dGridAdresler.Rows[SeciliSatir].Cells[4].Value.ToString();
        }
        int SeciliSatir;
        private void dGridAdresler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliSatir = e.RowIndex;
        }

        int kayitVarmi(string TcNo)
        {
            komut.CommandText = "Select * from Adresler where TcNo='" + TcNo + "'";
            baglan();
            OleDbDataReader data = komut.ExecuteReader();
            if (data.HasRows)
            {
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (kayitVarmi(txtTcNo.Text) == 1)
            {
                komut.CommandText = "Update Adresler set Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Adres='" + txtAdres.Text + "'Where Tc='" + txtTcNo.Text + "'";
                con.Open();
                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenmedi");
                }
                con.Close();
                verilerigetir();
            }

            else
            {
                MessageBox.Show("TcNo mevcut değil.");
            }

            txtTemizle();
        }

        void txtTemizle()
        {
            txtTcNo.Clear();
            txtAd.Clear();
            txtAdres.Clear();
            txtSoyad.Clear();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            komut.CommandText = "Select * from Adresler where TcNo='" + txtBoxAra.Text + "'";
            con.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtAd.Text = dr["Ad"].ToString().Trim();
                txtSoyad.Text = dr["Soyad"].ToString().Trim();
                txtAdres.Text = dr["Adres"].ToString().Trim();
                con.Close();
            }
            txtBoxAra.Focus();
        }
    }
}
