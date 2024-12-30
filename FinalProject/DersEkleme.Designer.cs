namespace FinalProject
{
    partial class DersEkleme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnÖğrenciEklemeFrm = new Button();
            btnBul = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            textDersAdi = new TextBox();
            textDersKodu = new TextBox();
            lblDersAdi = new Label();
            lblDersKodu = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnÖğrenciEklemeFrm);
            groupBox1.Controls.Add(btnBul);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(textDersAdi);
            groupBox1.Controls.Add(textDersKodu);
            groupBox1.Controls.Add(lblDersAdi);
            groupBox1.Controls.Add(lblDersKodu);
            groupBox1.Location = new Point(212, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 199);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Ekleme";
            // 
            // btnÖğrenciEklemeFrm
            // 
            btnÖğrenciEklemeFrm.Location = new Point(80, 170);
            btnÖğrenciEklemeFrm.Name = "btnÖğrenciEklemeFrm";
            btnÖğrenciEklemeFrm.Size = new Size(112, 23);
            btnÖğrenciEklemeFrm.TabIndex = 2;
            btnÖğrenciEklemeFrm.Text = "Öğrenci Ekleme";
            btnÖğrenciEklemeFrm.UseVisualStyleBackColor = true;
            btnÖğrenciEklemeFrm.Click += btnÖğrenciEklemeFrm_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(173, 127);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(85, 23);
            btnBul.TabIndex = 6;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(6, 127);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(92, 127);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // textDersAdi
            // 
            textDersAdi.Location = new Point(92, 76);
            textDersAdi.Name = "textDersAdi";
            textDersAdi.Size = new Size(100, 23);
            textDersAdi.TabIndex = 3;
            // 
            // textDersKodu
            // 
            textDersKodu.Location = new Point(92, 41);
            textDersKodu.Name = "textDersKodu";
            textDersKodu.Size = new Size(100, 23);
            textDersKodu.TabIndex = 2;
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(21, 79);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(51, 15);
            lblDersAdi.TabIndex = 1;
            lblDersAdi.Text = "Ders Adı";
            // 
            // lblDersKodu
            // 
            lblDersKodu.AutoSize = true;
            lblDersKodu.Location = new Point(21, 44);
            lblDersKodu.Name = "lblDersKodu";
            lblDersKodu.Size = new Size(61, 15);
            lblDersKodu.TabIndex = 0;
            lblDersKodu.Text = "Ders Kodu";
            // 
            // DersEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "DersEkleme";
            Text = "Form1";
            Load += DersEkleme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBul;
        private Button btnGuncelle;
        private Button btnKaydet;
        private TextBox textDersAdi;
        private TextBox textDersKodu;
        private Label lblDersAdi;
        private Label lblDersKodu;
        private Button btnÖğrenciEklemeFrm;
    }
}
