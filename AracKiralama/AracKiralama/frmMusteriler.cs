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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
            string clock = DateTime.Now.ToString("dd-MM-yyyy HH:mm dddd");
            this.lblClock.Text = clock;
        }
        cGenel gnl = new cGenel();
        private void txtMarkaBK_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERI where MKod like @MKod", con); ;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataTable dt_Adresler = new DataTable("Musteri");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.Parameters.AddWithValue("@MKod", txtTCBK.Text + "%");
                da.Fill(dt_Adresler);
                dGridMusterilerBK.DataSource = dt_Adresler;
                dGridMusterilerBK.Focus();
                verileriTemizle();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Hata", error.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        private void btnKayitEkleBK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into MUSTERI(MKod,Ad,Soyad,Tcno,Adres,Tel) values(@MKod,@Ad,@Soyad,@Tcno,@Adres,@Tel)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@MKod", txtMKodBK.Text);
                cmd.Parameters.AddWithValue("@Ad", txtAdBK.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyadBK.Text);
                cmd.Parameters.AddWithValue("@Tcno", txtTCBK.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdressBK.Text);
                cmd.Parameters.AddWithValue("@Tel", txtPhoneBK.Text);
                VeriGetir();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt eklendi.");
                    verileriTemizle();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata", ex.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        private void btnKayitGuncelleBK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update MUSTERI set Ad=@Ad,Soyad=@Soyad,Adres=@Adres,Tel=@Tel,MKod=@MKod where Tcno=@Tcno", con);
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@Ad", txtAdBK.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyadBK.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdressBK.Text);
                cmd.Parameters.AddWithValue("@Tel", txtPhoneBK.Text);
                cmd.Parameters.AddWithValue("@MKod", txtMKodBK.Text);
                cmd.Parameters.AddWithValue("@Tcno", txtTCBK.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Güncellendi.");
                    dGridMusterilerBK.Focus();
                    verileriTemizle();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }
                VeriGetir();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata", ex.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        private void btnKayitSilBK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from MUSTERI where Tcno=@Tcno", con);
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@Tcno", txtTCBK.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt silindi.");
                    dGridMusterilerBK.Focus();
                    verileriTemizle();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.");
                }
                 VeriGetir();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Hata", error.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        private void txtBoxTCSearchBK_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from MUSTERI where Ad like @Ad", con); ;
            try
            {
                DataTable dt_Ad = new DataTable("Musteri");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.Parameters.AddWithValue("@Ad", txtAdBK.Text + "%");
                da.Fill(dt_Ad);
                dGridMusterilerBK.DataSource = dt_Ad;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dGridMusterilerBK.Focus();
                verileriTemizle();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Hata", error.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
        void VeriGetir()
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select*from MUSTERI", con);
            try
            {
                DataTable dt_Adresler = new DataTable("Musteri");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt_Adresler);
                dGridMusterilerBK.DataSource = dt_Adresler;


            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata", Hata.Message.ToString());
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
        }
        void verileriTemizle()
        {
            txtAdBK.Clear();
            txtAdressBK.Clear();
            txtPhoneBK.Clear();
            txtSoyadBK.Clear();
            txtAdressBK.Clear();
            txtMKodBK.Clear();
            txtTCBK.Clear();
        }
        private void dGridMusterilerBK_DoubleClick(object sender, EventArgs e)
        {
            txtMKodBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[0].Value.ToString();
            txtTCBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[1].Value.ToString();
            txtAdBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[2].Value.ToString();
            txtSoyadBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[3].Value.ToString();
            txtAdressBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[4].Value.ToString();
            txtPhoneBK.Text = dGridMusterilerBK.Rows[secilenKayit].Cells[5].Value.ToString();
        }
        int secilenKayit;
        private void dGridMusterilerBK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilenKayit = e.RowIndex;
        }
    }
}
