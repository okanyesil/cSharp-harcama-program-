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
    public partial class frm_istatistik : Form
    {
        public frm_istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=harcamalar;Integrated Security=True");
        private void frm_istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand k1 = new SqlCommand("select count(*) from tbl_aylikHarcama",baglanti);
            SqlDataReader dr1 = k1.ExecuteReader();
            while (dr1.Read())
            {
                lbl_toplam.Text = dr1[0].ToString();
            }
            dr1.Close();
            SqlCommand k2 = new SqlCommand("select count(*) from tbl_aktif",baglanti);
            SqlDataReader dr2 = k2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_aktif.Text = dr2[0].ToString();
            }
            baglanti.Close();
        }

        private void btn_ana_Click(object sender, EventArgs e)
        {
            frm_ana frm = new frm_ana();
            frm.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
