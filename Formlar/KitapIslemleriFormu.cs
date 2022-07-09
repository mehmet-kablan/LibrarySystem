using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace KütüphaneOtomasyonuFinal.Formlar
{
    public partial class KitapIslemleriFormu : Form
    {
        public KitapIslemleriFormu()
        {
            InitializeComponent();
        }

        readonly OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kütüphane.accdb");
        OleDbCommand komut;
        OleDbDataAdapter dataAdapter;
        OleDbDataReader dataReader;

        void KitapListele()
        {
            int kitapSayisi;
            baglanti.Open();
            dataAdapter = new OleDbDataAdapter("SELECT *FROM Kitaplar", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridTümKitaplar.DataSource = tablo;
            kitapSayisi = tablo.Rows.Count;
            baglanti.Close();
        }
        private void KitapIslemleriFormu_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void KitapIslemleriFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaslangicFormu bslngcForm = new BaslangicFormu();
            bslngcForm.Show();
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            bool ayniSayi = false;
            komut = baglanti.CreateCommand();
            baglanti.Open();
            OleDbCommand KitapNumaralari = new OleDbCommand("SELECT KitapNo FROM Kitaplar ", baglanti);
            OleDbDataReader numaraReader = KitapNumaralari.ExecuteReader();
            komut.CommandText = "INSERT INTO Kitaplar (KitapNo,KitapAdi,KitapYazarı,BasimTarihi,Kategori,SayfaSayisi) values (@kitapNo,@ad,@yazar,@tarih,@kategori,@sayfasayi)";
            komut.Parameters.AddWithValue("@kitapNo", txtKitapNo.Text);
            komut.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtKitapYazari.Text);
            komut.Parameters.AddWithValue("@tarih", txtBasimTarihi.Text);
            komut.Parameters.AddWithValue("@kategori", txtKitapKategori.Text);
            komut.Parameters.AddWithValue("@sayfasayi", numericSayfaSayisi.Value.ToString());
            komut.Connection = baglanti;
            while (numaraReader.Read())
            {
                if (txtKitapNo.Text == numaraReader.GetValue(0).ToString())
                {
                    MessageBox.Show("Bu numaraya sahip bir öğrenci zaten var.Lütfen farklı bir numara giriniz.");
                    ayniSayi = true;
                }
            }
            if (!ayniSayi && !string.IsNullOrEmpty(txtKitapAdi.Text) &&
                !string.IsNullOrEmpty(txtKitapNo.Text) &&
                !string.IsNullOrEmpty(txtKitapYazari.Text) &&
                !string.IsNullOrEmpty(txtKitapKategori.Text) &&
                numericSayfaSayisi.Value > 0)
            {
                komut.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Lütfen veri girişlerine geçerli değerler girin.");
            }
            baglanti.Close();
            KitapListele();
            dataGridTümKitaplar.ClearSelection();
        }

        private void btn_KitapSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Kitaplar WHERE KitapNo=@no";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", dataGridTümKitaplar.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitapListele();
            dataGridTümKitaplar.ClearSelection();
        }

        private void btn_KitapDuzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Kitaplar Set KitapNo=@kitNo,KitapAdi=@isim,KitapYazarı=@yazar,BasimTarihi=@tarih,Kategori=@kategori,SayfaSayisi=@sayfasayi where KitapNo=@kitNo" ;
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitNo", txtKitapNo.Text);
            komut.Parameters.AddWithValue("@isim", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtKitapYazari.Text);
            komut.Parameters.AddWithValue("@tarih", txtBasimTarihi.Text);
            komut.Parameters.AddWithValue("@kategori", txtKitapKategori.Text);
            komut.Parameters.AddWithValue("@sayfasayi", numericSayfaSayisi.Value.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitapListele();
            dataGridTümKitaplar.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapNo.Text = dataGridTümKitaplar.CurrentRow.Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridTümKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtKitapYazari.Text = dataGridTümKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtBasimTarihi.Text = dataGridTümKitaplar.CurrentRow.Cells[3].Value.ToString();
            txtKitapKategori.Text = dataGridTümKitaplar.CurrentRow.Cells[4].Value.ToString();
            numericSayfaSayisi.Value = Convert.ToInt64(dataGridTümKitaplar.CurrentRow.Cells[5].Value);
        }

        private void txtBasimTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnKitapSorgula_Click(object sender, EventArgs e)
        {
            dataGridTümKitaplar.Visible = false;
            baglanti.Open();
            OleDbCommand gecerliKitaplar = new OleDbCommand("SELECT *FROM AlinanKitaplar WHERE KitapNo ='" + txtSorguKitapNo.Text + "'", baglanti);
            dataReader = gecerliKitaplar.ExecuteReader();
            if (dataReader.Read())
            {
                dataAdapter = new OleDbDataAdapter("SELECT *FROM AlinanKitaplar WHERE KitapNo ='" + txtSorguKitapNo.Text + "'", baglanti);
                DataTable tablo = new DataTable();
                dataAdapter.Fill(tablo);
                dataGridSorguAlinan.DataSource = tablo;
                dataAdapter = new OleDbDataAdapter("SELECT *FROM TeslimEdilenKitaplar WHERE KitapNo ='" + txtSorguKitapNo.Text + "'", baglanti);
                DataTable tablo2 = new DataTable();
                dataAdapter.Fill(tablo2);
                dataGridSorguTeslimEdilen.DataSource = tablo2;
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Bu Kitapla Alakalı Hiçbir İşlem Yok");
                dataGridTümKitaplar.Visible = true;
            }
            
            baglanti.Close();
        }

        private void btnTümKitaplar_Click(object sender, EventArgs e)
        {
            dataGridTümKitaplar.Visible = true;
            panel1.Visible = false;
            KitapListele();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            string[] kitaplar = { "Alinan Kitaplar", "Teslim Edilen Kitaplar", "Tüm Kitaplar" };
            double[] s1 = { 1 };
            double[] s5 = { 2 };
            double[] s6 = { 3 };
            dataAdapter = new OleDbDataAdapter("SELECT *FROM AlinanKitaplar", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataAdapter = new OleDbDataAdapter("SELECT *FROM TeslimEdilenKitaplar ", baglanti);
            DataTable tablo2 = new DataTable();
            dataAdapter.Fill(tablo2);
            double[] s2 = { dataGridTümKitaplar.RowCount };
            double[] s3 = { tablo.Rows.Count };
            double[] s4 = { tablo2.Rows.Count };
            panel1.Visible = false;
            panel2.Visible = false;
            dataGridTümKitaplar.Visible = false;
            GraphPane mypane = zedGraphControl1.GraphPane;
            mypane.Title.Text = "Wooow";
            mypane.XAxis.Title.Text = "";
            mypane.YAxis.Title.Text = "";
            zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = null;
            zedGraphControl1.GraphPane.AddBar("Tüm Kitapların Sayısı", s1, s2, Color.Red);
            zedGraphControl1.GraphPane.AddBar("Öğrenciye Verilen Kitapların Sayısı", s5, s3, Color.Blue);
            zedGraphControl1.Refresh();
            zedGraphControl1.GraphPane.XAxis.Scale.Max = 4;
            zedGraphControl1.GraphPane.XAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = dataGridTümKitaplar.RowCount+1;
            zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            zedGraphControl1.ZoomOutAll(zedGraphControl1.GraphPane);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            panel3.Visible = true;
        }
    }
}
