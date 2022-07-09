
namespace KütüphaneOtomasyonuFinal
{
    partial class BaslangicFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaslangicFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OgrenciIslemleri = new System.Windows.Forms.Button();
            this.btn_KitapIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÜTÜPHANE OTOMASYON SİSTEMİ";
            // 
            // btn_OgrenciIslemleri
            // 
            this.btn_OgrenciIslemleri.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OgrenciIslemleri.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_OgrenciIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_OgrenciIslemleri.Image")));
            this.btn_OgrenciIslemleri.Location = new System.Drawing.Point(81, 155);
            this.btn_OgrenciIslemleri.Name = "btn_OgrenciIslemleri";
            this.btn_OgrenciIslemleri.Size = new System.Drawing.Size(345, 320);
            this.btn_OgrenciIslemleri.TabIndex = 1;
            this.btn_OgrenciIslemleri.UseVisualStyleBackColor = true;
            this.btn_OgrenciIslemleri.Click += new System.EventHandler(this.btn_OgrenciIslemleri_Click);
            // 
            // btn_KitapIslemleri
            // 
            this.btn_KitapIslemleri.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapIslemleri.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_KitapIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_KitapIslemleri.Image")));
            this.btn_KitapIslemleri.Location = new System.Drawing.Point(616, 155);
            this.btn_KitapIslemleri.Name = "btn_KitapIslemleri";
            this.btn_KitapIslemleri.Size = new System.Drawing.Size(345, 320);
            this.btn_KitapIslemleri.TabIndex = 2;
            this.btn_KitapIslemleri.UseVisualStyleBackColor = true;
            this.btn_KitapIslemleri.Click += new System.EventHandler(this.btn_KitapIslemleri_Click);
            // 
            // BaslangicFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 583);
            this.Controls.Add(this.btn_KitapIslemleri);
            this.Controls.Add(this.btn_OgrenciIslemleri);
            this.Controls.Add(this.label1);
            this.Name = "BaslangicFormu";
            this.Text = "Kütüphane Otomasyon Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaslangicFormu_FormClosed);
            this.Load += new System.EventHandler(this.BaslangicFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OgrenciIslemleri;
        private System.Windows.Forms.Button btn_KitapIslemleri;
    }
}

