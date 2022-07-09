
namespace KütüphaneOtomasyonuFinal.Formlar
{
    partial class KitapIslemleriFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapKategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_KitapSil = new System.Windows.Forms.Button();
            this.btn_KitapDuzenle = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KitapEkle = new System.Windows.Forms.Button();
            this.dataGridTümKitaplar = new System.Windows.Forms.DataGridView();
            this.numericSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.txtBasimTarihi = new System.Windows.Forms.TextBox();
            this.btnKitapSorgula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSorguKitapNo = new System.Windows.Forms.TextBox();
            this.dataGridSorguAlinan = new System.Windows.Forms.DataGridView();
            this.dataGridSorguTeslimEdilen = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTümKitaplar = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTümKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorguAlinan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorguTeslimEdilen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(460, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Yayınlanma Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(514, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // txtKitapKategori
            // 
            this.txtKitapKategori.Location = new System.Drawing.Point(659, 17);
            this.txtKitapKategori.Multiline = true;
            this.txtKitapKategori.Name = "txtKitapKategori";
            this.txtKitapKategori.Size = new System.Drawing.Size(248, 26);
            this.txtKitapKategori.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(482, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 49;
            this.label4.Text = "Kitap Kategorisi:";
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(186, 81);
            this.txtKitapYazari.Multiline = true;
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(248, 26);
            this.txtKitapYazari.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "Kitabın Yazarı :";
            // 
            // btn_KitapSil
            // 
            this.btn_KitapSil.ForeColor = System.Drawing.Color.Black;
            this.btn_KitapSil.Location = new System.Drawing.Point(612, 128);
            this.btn_KitapSil.Name = "btn_KitapSil";
            this.btn_KitapSil.Size = new System.Drawing.Size(135, 49);
            this.btn_KitapSil.TabIndex = 46;
            this.btn_KitapSil.Text = "Numarası Girilen Kitabı Sil";
            this.btn_KitapSil.UseVisualStyleBackColor = true;
            this.btn_KitapSil.Click += new System.EventHandler(this.btn_KitapSil_Click);
            // 
            // btn_KitapDuzenle
            // 
            this.btn_KitapDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btn_KitapDuzenle.Location = new System.Drawing.Point(450, 128);
            this.btn_KitapDuzenle.Name = "btn_KitapDuzenle";
            this.btn_KitapDuzenle.Size = new System.Drawing.Size(135, 49);
            this.btn_KitapDuzenle.TabIndex = 45;
            this.btn_KitapDuzenle.Text = "Numarasi Girilen Kitabı Düzenle";
            this.btn_KitapDuzenle.UseVisualStyleBackColor = true;
            this.btn_KitapDuzenle.Click += new System.EventHandler(this.btn_KitapDuzenle_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(186, 49);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(248, 26);
            this.txtKitapAdi.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kitap Adı :";
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_KitapEkle.Location = new System.Drawing.Point(295, 128);
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Size = new System.Drawing.Size(135, 35);
            this.btn_KitapEkle.TabIndex = 40;
            this.btn_KitapEkle.Text = "Kitap Ekle";
            this.btn_KitapEkle.UseVisualStyleBackColor = true;
            this.btn_KitapEkle.Click += new System.EventHandler(this.btn_KitapEkle_Click);
            // 
            // dataGridTümKitaplar
            // 
            this.dataGridTümKitaplar.AllowUserToAddRows = false;
            this.dataGridTümKitaplar.AllowUserToDeleteRows = false;
            this.dataGridTümKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTümKitaplar.Location = new System.Drawing.Point(14, 270);
            this.dataGridTümKitaplar.Name = "dataGridTümKitaplar";
            this.dataGridTümKitaplar.ReadOnly = true;
            this.dataGridTümKitaplar.RowHeadersWidth = 51;
            this.dataGridTümKitaplar.RowTemplate.Height = 24;
            this.dataGridTümKitaplar.Size = new System.Drawing.Size(1008, 311);
            this.dataGridTümKitaplar.TabIndex = 39;
            this.dataGridTümKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // numericSayfaSayisi
            // 
            this.numericSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericSayfaSayisi.Location = new System.Drawing.Point(659, 49);
            this.numericSayfaSayisi.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericSayfaSayisi.Name = "numericSayfaSayisi";
            this.numericSayfaSayisi.Size = new System.Drawing.Size(248, 26);
            this.numericSayfaSayisi.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(68, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Kitap No :";
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(186, 17);
            this.txtKitapNo.Multiline = true;
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(248, 26);
            this.txtKitapNo.TabIndex = 60;
            // 
            // txtBasimTarihi
            // 
            this.txtBasimTarihi.Location = new System.Drawing.Point(659, 81);
            this.txtBasimTarihi.Multiline = true;
            this.txtBasimTarihi.Name = "txtBasimTarihi";
            this.txtBasimTarihi.Size = new System.Drawing.Size(248, 26);
            this.txtBasimTarihi.TabIndex = 61;
            this.txtBasimTarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasimTarihi_KeyPress);
            // 
            // btnKitapSorgula
            // 
            this.btnKitapSorgula.ForeColor = System.Drawing.Color.Black;
            this.btnKitapSorgula.Location = new System.Drawing.Point(583, 183);
            this.btnKitapSorgula.Name = "btnKitapSorgula";
            this.btnKitapSorgula.Size = new System.Drawing.Size(135, 35);
            this.btnKitapSorgula.TabIndex = 62;
            this.btnKitapSorgula.Text = "Kitap Sorgula";
            this.btnKitapSorgula.UseVisualStyleBackColor = true;
            this.btnKitapSorgula.Click += new System.EventHandler(this.btnKitapSorgula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(333, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 63;
            this.label3.Text = "Kitap No :";
            // 
            // txtSorguKitapNo
            // 
            this.txtSorguKitapNo.Location = new System.Drawing.Point(447, 189);
            this.txtSorguKitapNo.Multiline = true;
            this.txtSorguKitapNo.Name = "txtSorguKitapNo";
            this.txtSorguKitapNo.Size = new System.Drawing.Size(130, 26);
            this.txtSorguKitapNo.TabIndex = 64;
            // 
            // dataGridSorguAlinan
            // 
            this.dataGridSorguAlinan.AllowUserToAddRows = false;
            this.dataGridSorguAlinan.AllowUserToDeleteRows = false;
            this.dataGridSorguAlinan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSorguAlinan.Location = new System.Drawing.Point(3, 31);
            this.dataGridSorguAlinan.Name = "dataGridSorguAlinan";
            this.dataGridSorguAlinan.ReadOnly = true;
            this.dataGridSorguAlinan.RowHeadersWidth = 51;
            this.dataGridSorguAlinan.RowTemplate.Height = 24;
            this.dataGridSorguAlinan.Size = new System.Drawing.Size(1008, 139);
            this.dataGridSorguAlinan.TabIndex = 65;
            // 
            // dataGridSorguTeslimEdilen
            // 
            this.dataGridSorguTeslimEdilen.AllowUserToAddRows = false;
            this.dataGridSorguTeslimEdilen.AllowUserToDeleteRows = false;
            this.dataGridSorguTeslimEdilen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSorguTeslimEdilen.Location = new System.Drawing.Point(3, 202);
            this.dataGridSorguTeslimEdilen.Name = "dataGridSorguTeslimEdilen";
            this.dataGridSorguTeslimEdilen.ReadOnly = true;
            this.dataGridSorguTeslimEdilen.RowHeadersWidth = 51;
            this.dataGridSorguTeslimEdilen.RowTemplate.Height = 24;
            this.dataGridSorguTeslimEdilen.Size = new System.Drawing.Size(1008, 136);
            this.dataGridSorguTeslimEdilen.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 26);
            this.label8.TabIndex = 67;
            this.label8.Text = "Kitaba Sahip Olanlar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 26);
            this.label9.TabIndex = 68;
            this.label9.Text = "Kitabı Önceden Teslim Etmiş Olanlar :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridSorguAlinan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridSorguTeslimEdilen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(14, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 338);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // btnTümKitaplar
            // 
            this.btnTümKitaplar.ForeColor = System.Drawing.Color.Black;
            this.btnTümKitaplar.Location = new System.Drawing.Point(724, 183);
            this.btnTümKitaplar.Name = "btnTümKitaplar";
            this.btnTümKitaplar.Size = new System.Drawing.Size(146, 35);
            this.btnTümKitaplar.TabIndex = 70;
            this.btnTümKitaplar.Text = "Tüm Kitapları Listele";
            this.btnTümKitaplar.UseVisualStyleBackColor = true;
            this.btnTümKitaplar.Click += new System.EventHandler(this.btnTümKitaplar_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.ForeColor = System.Drawing.Color.Black;
            this.btnGrafikler.Location = new System.Drawing.Point(41, 142);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(135, 35);
            this.btnGrafikler.TabIndex = 71;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKitapKategori);
            this.panel2.Controls.Add(this.btnGrafikler);
            this.panel2.Controls.Add(this.btnTümKitaplar);
            this.panel2.Controls.Add(this.btn_KitapEkle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSorguKitapNo);
            this.panel2.Controls.Add(this.txtKitapAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_KitapDuzenle);
            this.panel2.Controls.Add(this.btnKitapSorgula);
            this.panel2.Controls.Add(this.btn_KitapSil);
            this.panel2.Controls.Add(this.txtBasimTarihi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtKitapNo);
            this.panel2.Controls.Add(this.txtKitapYazari);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericSayfaSayisi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(17, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 228);
            this.panel2.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.zedGraphControl1);
            this.panel3.Location = new System.Drawing.Point(8, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 569);
            this.panel3.TabIndex = 72;
            this.panel3.Visible = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(321, 17);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(686, 551);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // KitapIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridTümKitaplar);
            this.Name = "KitapIslemleriFormu";
            this.Text = "Kitap İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KitapIslemleriFormu_FormClosed);
            this.Load += new System.EventHandler(this.KitapIslemleriFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTümKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorguAlinan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSorguTeslimEdilen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_KitapSil;
        private System.Windows.Forms.Button btn_KitapDuzenle;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KitapEkle;
        private System.Windows.Forms.DataGridView dataGridTümKitaplar;
        private System.Windows.Forms.NumericUpDown numericSayfaSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.TextBox txtBasimTarihi;
        private System.Windows.Forms.Button btnKitapSorgula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSorguKitapNo;
        private System.Windows.Forms.DataGridView dataGridSorguAlinan;
        private System.Windows.Forms.DataGridView dataGridSorguTeslimEdilen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTümKitaplar;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button1;
    }
}