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

namespace TurkceSozluk
{
    public partial class Form1 : Form
    {
        OleDbConnection baglantim = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0;Data Source="
             + Application.StartupPath + "\\Sozluk.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sozluk";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbCommand komutekle = new OleDbCommand("insert into ingturkce (Ingilizce,Turkce) values ('" + textBox1.Text
                    + "','" + textBox2.Text + "')", baglantim);
                komutekle.ExecuteNonQuery();
                baglantim.Close();
                MessageBox.Show("Sozluk Veri Tabanina Eklendi...", "Veri Tabani Islemleri");
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Veri Tabani Islemleri");
                baglantim.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbCommand komutguncelleme = new OleDbCommand("update ingturkce set Turkce='" + textBox2.Text
                    + "' where Ingilizce ='" + textBox1.Text + "'", baglantim);
                komutguncelleme.ExecuteNonQuery();
                baglantim.Close();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Veri Tabani Islemleri");
                baglantim.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbCommand komutsil = new OleDbCommand("delete from ingturkce where Ingilizce='" + textBox1.Text + "'", baglantim);
                komutsil.ExecuteNonQuery();
                baglantim.Close();
                MessageBox.Show("Sozcuk Veri Tabanindan Silindi ", "Veri Tabani Islemleri");
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Veri Tabani Islemleri");
                baglantim.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                baglantim.Open();

                OleDbCommand komutarama = new OleDbCommand("select Ingilizce,Turkce  from ingturkce where Ingilizce like'" + textBox1.Text + "%'", baglantim);
                OleDbDataReader oku = komutarama.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["Ingilizce"].ToString() + "=" + oku["Turkce"].ToString());
                }
                baglantim.Close();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri Tabani Islemleri ");
                baglantim.Close();
            }
        }
    }
}
