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
    public partial class frm_ana : Form
    {
        public frm_ana()
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
        private void frm_ana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'harcamalarDataSet1.tbl_aylikHarcama' table. You can move, or remove it, as needed.
            this.tbl_aylikHarcamaTableAdapter1.Fill(this.harcamalarDataSet1.tbl_aylikHarcama);
            // TODO: This line of code loads data into the 'harcamalarDataSet.tbl_aylikHarcama' table. You can move, or remove it, as needed.
            this.tbl_aylikHarcamaTableAdapter.Fill(this.harcamalarDataSet.tbl_aylikHarcama);
            lbl_isim.Text = frm_giris.isim;
            baglanti.Open();
            SqlCommand sirala = new SqlCommand("select * from tbl_aktif ",baglanti);
            SqlDataReader dr1 = sirala.ExecuteReader();
            while (dr1.Read())
            {
                listBox1.Items.Add(dr1[0]);
            }
            baglanti.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'harcamalarDataSet1.tbl_aylikHarcama' table. You can move, or remove it, as needed.
            this.tbl_aylikHarcamaTableAdapter1.Fill(this.harcamalarDataSet1.tbl_aylikHarcama);
        }

        private void btn_harcama_Click(object sender, EventArgs e)
        {
            frm_harcamaGir frm = new frm_harcamaGir();
            frm.Show();
            this.Hide();
        }


       

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            //cikisYap();
            this.Close();
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            frm_istatistik frm = new frm_istatistik();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_gelir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_elektrik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_su.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_gaz.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_kart.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_aylikHarcama set ad=@p2 ,soyad=@p3,aylikGelir=@p4,elektrikFaturasi=@p5,suFaturasi=@p6,dogalgazFaturasi=@p7,kredikartiEkstre=@p8 where id=@p9",baglanti);
            
            komut.Parameters.AddWithValue("@p2", txt_ad.Text);
            komut.Parameters.AddWithValue("@p3", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p4", txt_gelir.Text);
            komut.Parameters.AddWithValue("@p5",txt_elektrik.Text );
            komut.Parameters.AddWithValue("@p6", txt_su.Text);
            komut.Parameters.AddWithValue("@p7", txt_gaz.Text);
            komut.Parameters.AddWithValue("@p8", txt_kart.Text);
            komut.Parameters.AddWithValue("@p9", txt_id.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_aylikHarcama where id=@s1",baglanti);
            sil.Parameters.AddWithValue("@s1", txt_id.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("kayıt başarıyla silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btn_grafik_Click(object sender, EventArgs e)
        {
            frm_grafik frm = new frm_grafik();
            frm.Show();
            this.Hide();
        }
    }
}
