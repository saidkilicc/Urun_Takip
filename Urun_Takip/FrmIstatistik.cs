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

namespace Urun_Takip
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C3O4SF6\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select Count(*) from TblKategori", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                LblToplamKategori.Text = dr[0].ToString();
            }
            baglanti.Close();

            //Toplam Ürün Sayısı Sonuc
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Count(*) from TblUrunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblUrunSayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();
        }
    }
}
