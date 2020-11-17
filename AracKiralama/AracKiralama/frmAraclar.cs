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
    public partial class frmAraclar : Form
    {
        public frmAraclar()
        {
            InitializeComponent();
            string clock = DateTime.Now.ToString("dd-MM-yyyy HH:mm dddd");
            this.lblClock.Text = clock;
        }
        cGenel gnl = new cGenel();

        private void frmAraclar_Load(object sender, EventArgs e)
        {

            VeriGetir();
        }
        void VeriGetir()
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select*from Araclar",con);
            try
            {
                DataTable dt_Adresler = new DataTable("Araclar");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt_Adresler);
                dGridAraclarBK.DataSource = dt_Adresler;
                

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

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into ARACLAR(AracNo,Marka,Model,Plaka) values(@AracNo,@Marka,@Model,@Plaka)",con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@AracNo", txtAracNoBK.Text);
                cmd.Parameters.AddWithValue("@Marka", txtMarkaBK.Text);
                cmd.Parameters.AddWithValue("@Model", txtModelBK.Text);
                cmd.Parameters.AddWithValue("@Plaka", txtPlakaBK.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt eklendi.");
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

        int secilenKayit;
        private void dGridAraclar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilenKayit = e.RowIndex;
        }

        private void dGridAraclar_DoubleClick(object sender, EventArgs e)
        {
            txtAracNoBK.Text = dGridAraclarBK.Rows[secilenKayit].Cells[0].Value.ToString();
            txtMarkaBK.Text = dGridAraclarBK.Rows[secilenKayit].Cells[1].Value.ToString();
            txtModelBK.Text = dGridAraclarBK.Rows[secilenKayit].Cells[2].Value.ToString();
            txtPlakaBK.Text = dGridAraclarBK.Rows[secilenKayit].Cells[3].Value.ToString();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Araclar set Marka=@Marka,Model=@Model,Plaka=@Plaka where AracNO=@AracNo",con);
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@Marka", txtMarkaBK.Text);
                cmd.Parameters.AddWithValue("@Model", txtModelBK.Text);
                cmd.Parameters.AddWithValue("@Plaka", txtPlakaBK.Text);
                cmd.Parameters.AddWithValue("@AracNo", txtAracNoBK.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Güncellendi.");
                    dGridAraclarBK.Focus();
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

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete from Araclar where AracNO=@AracNo",con);
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@AracNo", txtAracNoBK.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt silindi.");
                    dGridAraclarBK.Focus();
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

        void verileriTemizle()
        {
            txtModelBK.Clear();
            txtPlakaBK.Clear();
            txtMarkaBK.Clear();
            txtAracNoBK.Clear();
        }

        private void txtBoxMarkaSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Araclar where Marka like @Marka", con); ;
            try
            {
                DataTable dt_Adresler = new DataTable("Araclar");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.Parameters.AddWithValue("@Marka", txtBoxMarkaSearchBK.Text + "%");
                da.Fill(dt_Adresler);
                dGridAraclarBK.DataSource = dt_Adresler;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dGridAraclarBK.Focus();
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
    }
}
