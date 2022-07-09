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

namespace KütüphaneOtomasyonuFinal
{
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }

        readonly OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kütüphane.accdb");
        OleDbCommand komut;
        OleDbDataAdapter dataAdapter;

        void OgrenciListele()
        {
            baglanti.Open();
            dataAdapter = new OleDbDataAdapter("SELECT *FROM Ogrenciler", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            OgrenciListele();
            dataGridView1.ClearSelection();
        }

        private void btn_OgrenciEkle_Click(object sender, EventArgs e)
        {
            bool ayniSayi = false;
            komut = baglanti.CreateCommand();  
            baglanti.Open();
            OleDbCommand OgrenciNumaralari = new OleDbCommand("SELECT OgrenciNumarasi FROM Ogrenciler ", baglanti);
            OleDbDataReader numaraReader = OgrenciNumaralari.ExecuteReader();
            komut.CommandText = "INSERT INTO Ogrenciler (OgrenciNumarasi,OgrenciIsmi,OgrenciSoyismi) values (@numara,@ad,@soyad)";
            komut.Parameters.AddWithValue("@numara", txtOgrenciNum.Text);
            komut.Parameters.AddWithValue("@ad", txtOgrenciIsim.Text);
            komut.Parameters.AddWithValue("@soyad", txtOgrenciSoyisim.Text);
            komut.Connection = baglanti;
            while (numaraReader.Read())
            {
                if(txtOgrenciNum.Text == numaraReader.GetValue(0).ToString())
                {
                    MessageBox.Show("Bu numaraya sahip bir öğrenci zaten var.Lütfen farklı bir numara giriniz.");
                    ayniSayi = true;
                }
            }
            if(!ayniSayi && !string.IsNullOrEmpty(txtOgrenciIsim.Text) &&
                !string.IsNullOrEmpty(txtOgrenciNum.Text) &&
                !string.IsNullOrEmpty(txtOgrenciSoyisim.Text))
            {
                komut.ExecuteNonQuery();
            }
            
            baglanti.Close();

            OgrenciListele();
            dataGridView1.ClearSelection();
        }

        private void OgrenciIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaslangicFormu bslngc = new BaslangicFormu();
            bslngc.Show();
        }

        private void radioKitapAlim_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKitapAlim.Checked)
            {
                radioKitapTeslim.Checked = false;
            }
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        public string ogrenciSorguNum;
        public string gonderilecekIsim;
        public string gonderilecekSoyisim;
        public bool gonderilecekRadio;
        private void button1_Click(object sender, EventArgs e)
        {
            KütüphaneOtomasyonuFinal.Formlar.KitapAlimTeslimFormu alimTeslimForm = new Formlar.KitapAlimTeslimFormu();
            komut = baglanti.CreateCommand();
            baglanti.Open();
            OleDbCommand OgrenciNumaralari = new OleDbCommand("SELECT OgrenciNumarasi FROM Ogrenciler ", baglanti);
            OleDbCommand OgrenciIsimleri = new OleDbCommand("SELECT OgrenciIsmi FROM Ogrenciler ", baglanti);
            OleDbCommand OgrenciSoyisimleri = new OleDbCommand("SELECT OgrenciSoyismi FROM Ogrenciler ", baglanti);
            OleDbDataReader numaraReader = OgrenciNumaralari.ExecuteReader();
            OleDbDataReader isimReader = OgrenciIsimleri.ExecuteReader();
            OleDbDataReader soyisimReader = OgrenciSoyisimleri.ExecuteReader();
            while (numaraReader.Read() && isimReader.Read() && soyisimReader.Read())
            {
                if ((numaraReader.GetValue(0).ToString() == txtOgrenciNumSorgu.Text) && 
                    (radioKitapAlim.Checked || radioKitapTeslim.Checked))
                {
                    if (radioKitapAlim.Checked)
                    {
                        gonderilecekRadio = true;
                    }
                    else
                    {
                        gonderilecekRadio = false;
                    }
                    string ogrenciSorguNum = numaraReader.GetValue(0).ToString();
                    string gonderilecekIsim = isimReader.GetValue(0).ToString();
                    string gonderilecekSoyisim = soyisimReader.GetValue(0).ToString();
                    
                    KütüphaneOtomasyonuFinal.Formlar.KitapAlimTeslimFormu frm = new Formlar.KitapAlimTeslimFormu(gonderilecekIsim,gonderilecekSoyisim,ogrenciSorguNum,gonderilecekRadio);
                    frm.Show();
                    this.Hide();
                }
            }
            baglanti.Close();
            
        }

        private void btn_OgrenciSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Ogrenciler WHERE OgrenciNumarasi=@numara";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciListele();
            dataGridView1.ClearSelection();
        }

        private void btn_OgrenciDuzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Ogrenciler Set OgrenciNumarasi=@numara,OgrenciIsmi=@isim,OgrenciSoyismi=@soyisim WHERE OgrenciNumarasi=@numara";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@numara", txtOgrenciNum.Text);
            komut.Parameters.AddWithValue("@isim", txtOgrenciIsim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtOgrenciSoyisim.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciListele();
            dataGridView1.ClearSelection();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrenciIsim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciSoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
