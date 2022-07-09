
namespace KütüphaneOtomasyonuFinal
{
    partial class OgrenciIslemleri
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
            this.btn_OgrenciEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OgrenciDuzenle = new System.Windows.Forms.Button();
            this.btn_OgrenciSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOgrenciSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKitapTeslim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioKitapTeslim = new System.Windows.Forms.RadioButton();
            this.radioKitapAlim = new System.Windows.Forms.RadioButton();
            this.btnDevam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciNumSorgu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OgrenciEkle
            // 
            this.btn_OgrenciEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_OgrenciEkle.Location = new System.Drawing.Point(506, 188);
            this.btn_OgrenciEkle.Name = "btn_OgrenciEkle";
            this.btn_OgrenciEkle.Size = new System.Drawing.Size(135, 35);
            this.btn_OgrenciEkle.TabIndex = 0;
            this.btn_OgrenciEkle.Text = "Öğrenci Ekle";
            this.btn_OgrenciEkle.UseVisualStyleBackColor = true;
            this.btn_OgrenciEkle.Click += new System.EventHandler(this.btn_OgrenciEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(535, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // txtOgrenciNum
            // 
            this.txtOgrenciNum.Location = new System.Drawing.Point(741, 12);
            this.txtOgrenciNum.Multiline = true;
            this.txtOgrenciNum.Name = "txtOgrenciNum";
            this.txtOgrenciNum.Size = new System.Drawing.Size(248, 26);
            this.txtOgrenciNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 3;
            // 
            // txtOgrenciIsim
            // 
            this.txtOgrenciIsim.Location = new System.Drawing.Point(741, 66);
            this.txtOgrenciIsim.Multiline = true;
            this.txtOgrenciIsim.Name = "txtOgrenciIsim";
            this.txtOgrenciIsim.Size = new System.Drawing.Size(248, 26);
            this.txtOgrenciIsim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(588, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci İsmi :";
            // 
            // btn_OgrenciDuzenle
            // 
            this.btn_OgrenciDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btn_OgrenciDuzenle.Location = new System.Drawing.Point(669, 181);
            this.btn_OgrenciDuzenle.Name = "btn_OgrenciDuzenle";
            this.btn_OgrenciDuzenle.Size = new System.Drawing.Size(162, 48);
            this.btn_OgrenciDuzenle.TabIndex = 6;
            this.btn_OgrenciDuzenle.Text = "Numarasi Girilen Öğrenciyi Düzenle";
            this.btn_OgrenciDuzenle.UseVisualStyleBackColor = true;
            this.btn_OgrenciDuzenle.Click += new System.EventHandler(this.btn_OgrenciDuzenle_Click);
            // 
            // btn_OgrenciSil
            // 
            this.btn_OgrenciSil.ForeColor = System.Drawing.Color.Black;
            this.btn_OgrenciSil.Location = new System.Drawing.Point(860, 181);
            this.btn_OgrenciSil.Name = "btn_OgrenciSil";
            this.btn_OgrenciSil.Size = new System.Drawing.Size(143, 48);
            this.btn_OgrenciSil.TabIndex = 7;
            this.btn_OgrenciSil.Text = "Numarasi Girilen Öğrenciyi Sil";
            this.btn_OgrenciSil.UseVisualStyleBackColor = true;
            this.btn_OgrenciSil.Click += new System.EventHandler(this.btn_OgrenciSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 578);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtOgrenciSoyisim
            // 
            this.txtOgrenciSoyisim.Location = new System.Drawing.Point(741, 121);
            this.txtOgrenciSoyisim.Multiline = true;
            this.txtOgrenciSoyisim.Name = "txtOgrenciSoyisim";
            this.txtOgrenciSoyisim.Size = new System.Drawing.Size(248, 26);
            this.txtOgrenciSoyisim.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(551, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğrenci Soyismi :";
            // 
            // btnKitapTeslim
            // 
            this.btnKitapTeslim.ForeColor = System.Drawing.Color.Black;
            this.btnKitapTeslim.Location = new System.Drawing.Point(626, 277);
            this.btnKitapTeslim.Name = "btnKitapTeslim";
            this.btnKitapTeslim.Size = new System.Drawing.Size(246, 58);
            this.btnKitapTeslim.TabIndex = 12;
            this.btnKitapTeslim.Text = "Kitap Alım/Teslim İşlemleri İçin Tıklayınız";
            this.btnKitapTeslim.UseVisualStyleBackColor = true;
            this.btnKitapTeslim.Click += new System.EventHandler(this.btnKitapTeslim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioKitapTeslim);
            this.panel1.Controls.Add(this.radioKitapAlim);
            this.panel1.Controls.Add(this.btnDevam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOgrenciNumSorgu);
            this.panel1.Location = new System.Drawing.Point(541, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 208);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // radioKitapTeslim
            // 
            this.radioKitapTeslim.AutoSize = true;
            this.radioKitapTeslim.ForeColor = System.Drawing.Color.Black;
            this.radioKitapTeslim.Location = new System.Drawing.Point(225, 102);
            this.radioKitapTeslim.Name = "radioKitapTeslim";
            this.radioKitapTeslim.Size = new System.Drawing.Size(106, 21);
            this.radioKitapTeslim.TabIndex = 16;
            this.radioKitapTeslim.TabStop = true;
            this.radioKitapTeslim.Text = "Kitap Teslim";
            this.radioKitapTeslim.UseVisualStyleBackColor = true;
            // 
            // radioKitapAlim
            // 
            this.radioKitapAlim.AutoSize = true;
            this.radioKitapAlim.ForeColor = System.Drawing.Color.Black;
            this.radioKitapAlim.Location = new System.Drawing.Point(128, 102);
            this.radioKitapAlim.Name = "radioKitapAlim";
            this.radioKitapAlim.Size = new System.Drawing.Size(91, 21);
            this.radioKitapAlim.TabIndex = 15;
            this.radioKitapAlim.TabStop = true;
            this.radioKitapAlim.Text = "Kitap Alım";
            this.radioKitapAlim.UseVisualStyleBackColor = true;
            this.radioKitapAlim.CheckedChanged += new System.EventHandler(this.radioKitapAlim_CheckedChanged);
            // 
            // btnDevam
            // 
            this.btnDevam.ForeColor = System.Drawing.Color.Black;
            this.btnDevam.Location = new System.Drawing.Point(155, 144);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(135, 35);
            this.btnDevam.TabIndex = 14;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "İşlem yapmak istediğiniz öğrenci numarasını giriniz";
            // 
            // txtOgrenciNumSorgu
            // 
            this.txtOgrenciNumSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciNumSorgu.Location = new System.Drawing.Point(175, 47);
            this.txtOgrenciNumSorgu.Name = "txtOgrenciNumSorgu";
            this.txtOgrenciNumSorgu.Size = new System.Drawing.Size(196, 26);
            this.txtOgrenciNumSorgu.TabIndex = 0;
            // 
            // OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKitapTeslim);
            this.Controls.Add(this.txtOgrenciSoyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_OgrenciSil);
            this.Controls.Add(this.btn_OgrenciDuzenle);
            this.Controls.Add(this.txtOgrenciIsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OgrenciEkle);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Name = "OgrenciIslemleri";
            this.Text = "Öğrenci İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciIslemleri_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OgrenciEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciIsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OgrenciDuzenle;
        private System.Windows.Forms.Button btn_OgrenciSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOgrenciSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKitapTeslim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciNumSorgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.RadioButton radioKitapTeslim;
        private System.Windows.Forms.RadioButton radioKitapAlim;
    }
}