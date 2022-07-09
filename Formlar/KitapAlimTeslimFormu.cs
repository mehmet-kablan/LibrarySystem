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

namespace KütüphaneOtomasyonuFinal.Formlar
{
    public partial class KitapAlimTeslimFormu : Form
    {
        public KitapAlimTeslimFormu()
        {
            InitializeComponent();
        }

        readonly OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kütüphane.accdb");
        OleDbCommand komut,komut2;
        OleDbDataAdapter dataAdapter;
        OleDbDataReader dataReader;
        readonly private string gelenIsim, gelenSoyisim, gelenOgrenciNum;
        readonly private bool gelenRadio;

        void ogrenciyeAitKitapListele()
        {
            int ogrenciCeza = 0;
            baglanti.Open();
            dataAdapter = new OleDbDataAdapter("SELECT *FROM AlinanKitaplar WHERE OgrenciNumarasi = '"+gelenOgrenciNum+"'", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow currentRow = dataGridView1.Rows[i];
                if((DateTime)currentRow.Cells[6].Value < DateTime.Now.AddDays(2))
                {
                    currentRow.Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Yellow };
                    if((DateTime)currentRow.Cells[6].Value < DateTime.Now)
                    {
                        currentRow.Cells[6].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                        ogrenciCeza = ogrenciCeza + ((DateTime)currentRow.Cells[6].Value - DateTime.Now).Days;
                        lblCeza.Text = Math.Abs(ogrenciCeza).ToString() + " TL";
                    }
                }
            }
            dataAdapter = new OleDbDataAdapter("SELECT *FROM TeslimEdilenKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "'", baglanti);
            DataTable tablo1 = new DataTable();
            dataAdapter.Fill(tablo1);
            dataGridView2.DataSource = tablo1;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Lime;

            baglanti.Close();
        }
        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            bool ayniKitapMevcut = false;
            string kitapNo = "";
            String kesilecekString = comboTümKitaplar.SelectedItem.ToString();
            int ilkKarakter = kesilecekString.IndexOf("-") + "-".Length;
            int ikinciKarakter = kesilecekString.LastIndexOf("-");
            String alinanKitapAdi = kesilecekString.Substring(ilkKarakter, ikinciKarakter - ilkKarakter);
            komut = baglanti.CreateCommand();
            baglanti.Open();
            dataAdapter = new OleDbDataAdapter("SELECT *FROM Kitaplar", baglanti);
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Kitaplar";
            dataReader = komut.ExecuteReader();
            komut.CommandText = "INSERT INTO AlinanKitaplar (KitapNo,KitapAdi,OgrenciNumarasi,OgrenciAdi,OgrenciSoyadi,AlinanTarih,TeslimTarihi) values (@kitapNo,@kitapAdi,@ogrenciNum,@ogrenciAd,@ogrenciSoyad,@alinanTarih,@teslimTarihi)";
            while (dataReader.Read())
            {
                if (comboTümKitaplar.SelectedItem.ToString().Contains(dataReader["KitapAdi"].ToString()))
                {
                    kitapNo = dataReader["KitapNo"].ToString();
                }
            }
            dataReader.Close();
            komut.Parameters.AddWithValue("@KitapNo", kitapNo);
            komut.Parameters.AddWithValue("@KitapAdi", alinanKitapAdi);
            komut.Parameters.AddWithValue("@ogrenciNum", lblOgrenciNum.Text);
            komut.Parameters.AddWithValue("@ogrenciAdi", lblOgrenciIsim.Text);
            komut.Parameters.AddWithValue("@ogrenciSoyadi", lblOgrenciSoyisim.Text);
            komut.Parameters.AddWithValue("@alinanTarih", DateTime.Today.ToShortDateString());
            DateTime teslimTarihi = DateTime.Today.AddDays((double)numericTeslimGün.Value);
            komut.Parameters.AddWithValue("@teslimTarihi", teslimTarihi.ToShortDateString());
            komut.Connection = baglanti;
            OleDbDataReader dataReader2;
            komut2 = baglanti.CreateCommand();
            // dataAdapter = new OleDbDataAdapter("SELECT *FROM AlinanKitaplar", baglanti);
            komut2 = new OleDbCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "SELECT [KitapNo] FROM AlinanKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "' AND KitapNo = '" + kitapNo + "'";
            dataReader2 = komut2.ExecuteReader();
            if (dataReader2.Read())
            {
                ayniKitapMevcut = true;
            }
            else
            {
                ayniKitapMevcut = false;
            }
            try {
                if (!ayniKitapMevcut)
                {
                    komut.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Aynı kitaptan birden fazla alamazsınız");
                }
            }catch(Exception)
            {
                MessageBox.Show("Aynı Kitaptan birden fazla alamazsınız.");
            }
            baglanti.Close();
            ogrenciyeAitKitapListele();
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            string kitapNo = "";
            if (!string.IsNullOrEmpty(comboTümKitaplar.Text))
            {
                kitapNo = string.Concat(comboTümKitaplar.SelectedItem.ToString().TakeWhile((c) => c != '-'));
            }
            DateTime alinanTeslimTarihi = DateTime.Today;
            string alinanKitapAdi = "";
            komut = baglanti.CreateCommand();
            baglanti.Open();
            OleDbCommand teslimTarihi = new OleDbCommand();
            teslimTarihi.CommandText = ("SELECT TeslimTarihi,KitapAdi From AlinanKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "' AND KitapNo = '" + kitapNo + "'");
            teslimTarihi.Connection = baglanti;
            dataReader = teslimTarihi.ExecuteReader();
            while (dataReader.Read())
            {
                alinanTeslimTarihi = (DateTime)dataReader.GetValue(0);
                alinanKitapAdi = dataReader.GetValue(1).ToString();
            }
            
            komut.CommandText = "INSERT INTO TeslimEdilenKitaplar (KitapNo,KitapAdi,EnGecTeslimTarihi,TeslimEdilenTarih,OgrenciNumarasi,OgrenciAdi,OgrenciSoyadi) values (@kitapNo,@kitapAdi,@teslimTarihi,@teslimEdilenTarih,@ogrenciNum,@ogrenciAdi,@ogrenciSoyadi)";
            komut.Parameters.AddWithValue("@kitapNo", kitapNo);
            komut.Parameters.AddWithValue("@kitapAdi", alinanKitapAdi);
            komut.Parameters.AddWithValue("@teslimTarihi", alinanTeslimTarihi.ToShortDateString());
            komut.Parameters.AddWithValue("@teslimEdilenTarih", DateTime.Now.ToShortDateString());
            komut.Parameters.AddWithValue("@ogrenciNum", lblOgrenciNum.Text);
            komut.Parameters.AddWithValue("@ogrenciAdi", lblOgrenciIsim.Text);
            komut.Parameters.AddWithValue("@ogrenciSoyadi", lblOgrenciSoyisim.Text);
            komut.Connection = baglanti;
            if (!string.IsNullOrEmpty(comboTümKitaplar.Text))
            {
                komut.ExecuteNonQuery();
                komut.CommandText = "DELETE *FROM AlinanKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "' AND KitapNo = '" + kitapNo + "'";
                komut.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bir kitap seçiniz.");
            }

            baglanti.Close();
            comboTümKitaplar.Items.Clear();
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT *FROM AlinanKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "'";
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                comboTümKitaplar.Items.Add(dataReader["KitapNo"] + "-" + dataReader["KitapAdi"]);
            }
            baglanti.Close();
            ogrenciyeAitKitapListele();
            comboTümKitaplar.Text = "Bir Kitap Seçin...";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri ogrForm = new OgrenciIslemleri();
            ogrForm.Show();
            this.Hide();
        }

        public KitapAlimTeslimFormu(string isim, string soyisim, string ogrenciNum, bool radio)
        {
            gelenIsim = isim;
            gelenSoyisim = soyisim;
            gelenOgrenciNum = ogrenciNum;
            gelenRadio = radio;
            InitializeComponent();
        }
        private void KitapAlimTeslimFormu_Load(object sender, EventArgs e)
        {
            ogrenciyeAitKitapListele();
            lblOgrenciNum.Text = gelenOgrenciNum;
            lblOgrenciIsim.Text = gelenIsim;
            lblOgrenciSoyisim.Text = gelenSoyisim;
            if (!gelenRadio)
            {
                btnKitapAl.Visible = false;
                label5.Text = "Teslim edilecek kitap:";
                numericTeslimGün.Visible = false;
                label6.Visible = false;
                baglanti.Open();
                komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT *FROM AlinanKitaplar WHERE OgrenciNumarasi = '" + gelenOgrenciNum + "'";
                dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    comboTümKitaplar.Items.Add(dataReader["KitapNo"] + "-" + dataReader["KitapAdi"]);
                }
                baglanti.Close();
            }
            else
            {
                btnKitapTeslim.Visible = false;
                baglanti.Open();
                komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM Kitaplar";
                dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    comboTümKitaplar.Items.Add(dataReader["KitapNo"] + "-" + dataReader["KitapAdi"] + "-" + dataReader["KitapYazarı"]);
                }
                baglanti.Close();
            }

        }
    }
}
