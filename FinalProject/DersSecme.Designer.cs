namespace FinalProject
{
    partial class DersSecme
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
            label1 = new Label();
            lblOgrenciBilgileri = new Label();
            lblDersler = new Label();
            dataGridView1 = new DataGridView();
            btnDersKaydet = new Button();
            lblSecilenDersler = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(83, 46);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(187, 15);
            lblOgrenciBilgileri.TabIndex = 1;
            lblOgrenciBilgileri.Text = "Öğrenci Bilgilerinin Geleceği Label";
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(83, 128);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(53, 15);
            lblDersler.TabIndex = 2;
            lblDersler.Text = "DERSLER";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(491, 150);
            dataGridView1.TabIndex = 3;
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(339, 357);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(190, 30);
            btnDersKaydet.TabIndex = 4;
            btnDersKaydet.Text = "Öğrenci Derslerini Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // lblSecilenDersler
            // 
            lblSecilenDersler.AutoSize = true;
            lblSecilenDersler.Location = new Point(83, 357);
            lblSecilenDersler.Name = "lblSecilenDersler";
            lblSecilenDersler.Size = new Size(204, 15);
            lblSecilenDersler.TabIndex = 5;
            lblSecilenDersler.Text = "Seçilen Ders Bilgileinin Geleceği Label";
            // 
            // DersSecme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecilenDersler);
            Controls.Add(btnDersKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(lblDersler);
            Controls.Add(lblOgrenciBilgileri);
            Controls.Add(label1);
            Name = "DersSecme";
            Text = " ";
            Load += DersSecme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOgrenciBilgileri;
        private Label lblDersler;
        private DataGridView dataGridView1;
        private Button btnDersKaydet;
        private Label lblSecilenDersler;
    }
}