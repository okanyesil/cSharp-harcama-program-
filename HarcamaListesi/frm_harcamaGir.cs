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
    public partial class frm_harcamaGir : Form
    {
        public frm_harcamaGir()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=harcamalar;Integrated Security=True");
        public void cikisYap()
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_aktif where kullaniciAdi=@k1", baglanti);
            sil.Parameters.AddWithValue("@k1", frm_giris.isim);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_aylikHarcama ("+cmb_islem.Text+") values (@p1) select * from tbl_aylikHarcama where ad="+comboBox1.Text+"",baglanti);
            komut.Parameters.AddWithValue("@p1", txt_tutar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            frm_ana frm = new frm_ana();
            frm.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            
           // cikisYap();
            
            this.Close();
        }

        private void frm_harcamaGir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand oku = new SqlCommand("select * from tbl_aylikHarcama",baglanti);
            SqlDataReader dr1 = oku.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[1]);
            }

            baglanti.Close();
        }
    }
}
