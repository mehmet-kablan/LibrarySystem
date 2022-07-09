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
    public partial class BaslangicFormu : Form
    {
        public BaslangicFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BaslangicFormu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_OgrenciIslemleri_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri ogrForm = new OgrenciIslemleri();
            ogrForm.Show();
            this.Close();
        }

        private void btn_KitapIslemleri_Click(object sender, EventArgs e)
        {
            Formlar.KitapIslemleriFormu ktpForm = new Formlar.KitapIslemleriFormu();
            ktpForm.Show();
            this.Close();
        }

        private void BaslangicFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
