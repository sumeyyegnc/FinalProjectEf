namespace FinalProject
{
    partial class OgrenciEkleme
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
            groupBox1 = new GroupBox();
            combobox_siniflar = new ComboBox();
            lblSinifSeçimi = new Label();
            textNumara = new TextBox();
            textSoyad = new TextBox();
            textAd = new TextBox();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnBul = new Button();
            btnDersSecimi = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combobox_siniflar);
            groupBox1.Controls.Add(lblSinifSeçimi);
            groupBox1.Controls.Add(textNumara);
            groupBox1.Controls.Add(textSoyad);
            groupBox1.Controls.Add(textAd);
            groupBox1.Controls.Add(lblNumara);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Location = new Point(153, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekleme";
            // 
            // combobox_siniflar
            // 
            combobox_siniflar.FormattingEnabled = true;
            combobox_siniflar.Location = new Point(108, 180);
            combobox_siniflar.Name = "combobox_siniflar";
            combobox_siniflar.Size = new Size(100, 23);
            combobox_siniflar.TabIndex = 1;
            // 
            // lblSinifSeçimi
            // 
            lblSinifSeçimi.AutoSize = true;
            lblSinifSeçimi.Location = new Point(22, 183);
            lblSinifSeçimi.Name = "lblSinifSeçimi";
            lblSinifSeçimi.Size = new Size(69, 15);
            lblSinifSeçimi.TabIndex = 6;
            lblSinifSeçimi.Text = "Sınıf Seçiniz";
            // 
            // textNumara
            // 
            textNumara.Location = new Point(108, 138);
            textNumara.Name = "textNumara";
            textNumara.Size = new Size(100, 23);
            textNumara.TabIndex = 5;
            // 
            // textSoyad
            // 
            textSoyad.Location = new Point(108, 94);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(100, 23);
            textSoyad.TabIndex = 4;
            // 
            // textAd
            // 
            textAd.Location = new Point(108, 56);
            textAd.Name = "textAd";
            textAd.Size = new Size(100, 23);
            textAd.TabIndex = 3;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(41, 146);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(50, 15);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(52, 97);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(63, 59);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(153, 292);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(70, 23);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(229, 292);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(121, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(358, 292);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(60, 23);
            btnBul.TabIndex = 9;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(229, 332);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(121, 23);
            btnDersSecimi.TabIndex = 10;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // OgrenciEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox1);
            Name = "OgrenciEkleme";
            Text = "OgrenciEkleme";
            Load += OgrenciEkleme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textNumara;
        private TextBox textSoyad;
        private TextBox textAd;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblSinifSeçimi;
        private ComboBox combobox_siniflar;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnDersSecimi;
    }
}