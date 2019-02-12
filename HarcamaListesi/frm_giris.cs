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

namespace HarcamaListesi
{
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=harcamalar;Integrated Security=True");
        private void frm_giris_Load(object sender, EventArgs e)
        {

        }
        public static string isim;
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand k1 = new SqlCommand("select * from tbl_yonetici where kullaniciAdi=@p1 and sifre=@p2",baglanti);
            k1.Parameters.AddWithValue("@p1", txt_kullaniciAd.Text);
            k1.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr1 = k1.ExecuteReader();
            if (dr1.Read())
            {
                dr1.Close();
                SqlCommand k2 = new SqlCommand("insert into tbl_aktif (kullaniciAdi) values(@e1)",baglanti);
                k2.Parameters.AddWithValue("@e1", txt_kullaniciAd.Text);
                k2.ExecuteNonQuery();
                isim = txt_kullaniciAd.Text;
                frm_ana frm = new frm_ana();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı ve şifrenizi kontrol ediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            baglanti.Close();
        }

        private void btn_kullaniciEkle_Click(object sender, EventArgs e)
        {
            frm_kullaniciOlustur frm = new frm_kullaniciOlustur();
            frm.Show();
            this.Hide();
        }
    }
}
