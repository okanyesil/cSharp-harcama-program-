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
    public partial class frm_grafik : Form
    {
        public frm_grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B0GOLQN\\SQLEXPRESS;Initial Catalog=harcamalar;Integrated Security=True");
        private void frm_grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("select * from tbl_aylikHarcama",baglanti);
            SqlDataReader dr1 = ekle.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[1]);
            }
            dr1.Close();

           
            baglanti.Close();

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            baglanti.Open();
            SqlCommand grafik = new SqlCommand("select aylikGelir,elektrikFaturasi,suFaturasi,dogalgazFaturasi,kredikartiEkstre,ad from tbl_aylikHarcama where ad=@p1", baglanti);
            grafik.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr2 = grafik.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["isim-harcama"].Points.AddY(dr2[0]);
                chart1.Series["isim-harcama"].Points.AddY(dr2[1]);
                chart1.Series["isim-harcama"].Points.AddY(dr2[2]);
                chart1.Series["isim-harcama"].Points.AddY(dr2[3]);
                chart1.Series["isim-harcama"].Points.AddY(dr2[4]);
                chart1.Series["isim-harcama"].Points[0].AxisLabel = "aylik gelir";
                chart1.Series["isim-harcama"].Points[1].AxisLabel = "Elektrik Faturası";
                chart1.Series["isim-harcama"].Points[2].AxisLabel = "Su faturası";
                chart1.Series["isim-harcama"].Points[3].AxisLabel = "Dogalgaz Faturası";
                chart1.Series["isim-harcama"].Points[4].AxisLabel = "Kredi Kartı Ekstre";
            }
            baglanti.Close();
        }

        private void chart1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void chart1_AnnotationTextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ana frm = new frm_ana();
            frm.Show();
            this.Hide();
        }
    }
}
