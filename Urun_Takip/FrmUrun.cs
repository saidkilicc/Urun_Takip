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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C3O4SF6\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select UrunID,UrunAd,Stok,AlisFiyat,SatisFiyat,Ad,Kategori From TblUrunler Inner join TblKategori On TblUrunler.Kategori=TblKategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["Kategori"].Visible = false;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from TblKategori", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            TxtCmbKategori.DisplayMember = "Ad";
            TxtCmbKategori.ValueMember= "ID";
            TxtCmbKategori.DataSource= dt2;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into TblUrunler (UrunAd,Stok,AlisFiyat,SatisFiyat,Kategori) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut3.Parameters.AddWithValue("@p1",TxtUrunAdi.Text);
            komut3.Parameters.AddWithValue("@p2", NmrcStok.Value);
            komut3.Parameters.AddWithValue("@p3",TxtAlisFiyat.Text);
            komut3.Parameters.AddWithValue("@p4", TxtSatisFiyat.Text);
            komut3.Parameters.AddWithValue("@p5", TxtCmbKategori.SelectedValue);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti");
             
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("delete from TblUrunler where UrunID=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", TxtUrunId.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarı ile gerçekleşti");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrunAdi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            NmrcStok.Value = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
            TxtAlisFiyat.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSatisFiyat.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtCmbKategori.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update TblUrunler set UrunAd=@p1,Stok=@p2,AlisFiyat=@p3,SatisFiyat=@p4,Kategori=@p5 where UrunID=@p6", baglanti);
            komut5.Parameters.AddWithValue("@p1",TxtUrunAdi.Text);
            komut5.Parameters.AddWithValue("@p2", NmrcStok.Value);
            komut5.Parameters.AddWithValue("@p3", decimal.Parse(TxtAlisFiyat.Text));
            komut5.Parameters.AddWithValue("@p4", decimal.Parse(TxtSatisFiyat.Text));
            komut5.Parameters.AddWithValue("@p5", TxtCmbKategori.SelectedValue);
            komut5.Parameters.AddWithValue("@p6", TxtUrunId.Text);
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün bilgileribaşarıyla güncellendi","Güncelleme",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
