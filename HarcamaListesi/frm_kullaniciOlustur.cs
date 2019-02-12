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
    public partial class frm_kullaniciOlustur : Form
    {
        public frm_kullaniciOlustur()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=harcamalar;Integrated Security=True");
        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kulEkle = new SqlCommand("insert into tbl_yonetici (kullaniciAdi,sifre) values (@p1,@p2)",baglanti);
            kulEkle.Parameters.AddWithValue("@p1", txt_kullaniciAdi.Text);
            kulEkle.Parameters.AddWithValue("@p2", txt_sifre.Text);
          
            kulEkle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_giris frm = new frm_giris();
            frm.Show();
            this.Hide();
        }

        

    }
}
