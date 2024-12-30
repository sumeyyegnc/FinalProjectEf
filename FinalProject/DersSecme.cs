﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DersSecme : Form
    {

        private string Ad;
        private string Soyad;
        private string Numara;
        private string SinifAdi;
        public DersSecme(string Ad, string Soyad, string Numara, string SinifAdi)
        {
            InitializeComponent();

            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Numara = Numara;
            this.SinifAdi = SinifAdi;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DersSecme_Load(object sender, EventArgs e)
        {

            lblOgrenciBilgileri.Text = $"Ad Soyad: {Ad} {Soyad}\n" +
                      $"Numara: {Numara}\n" +
                      $"Sınıf: {SinifAdi}";


            using (var context = new FinalDbContext())
            {
                var Dersler = context.Dersler.ToList();

                dataGridView1.DataSource = Dersler;
            }


            dataGridView1.Columns["DersKod"].HeaderText = "Ders Kod";
            dataGridView1.Columns["DersAd"].HeaderText = "Ders Ad";

            dataGridView1.Columns["DersId"].Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;


        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int dersAdiIndex = dataGridView1.Columns["DersAd"].Index;
                int dersKoduIndex = dataGridView1.Columns["DersKod"].Index;

                string dersAdi = selectedRow.Cells[dersAdiIndex].Value?.ToString() ?? "Veri yok";
                string dersKodu = selectedRow.Cells[dersKoduIndex].Value?.ToString() ?? "Veri yok";

                lblSecilenDersler.Text = $"Ders Adı: {dersAdi}, Ders Kodu: {dersKodu}";
                string ogrenciNumarasi = this.Numara;

                using (var context = new FinalDbContext())
                {
        
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == ogrenciNumarasi);

                    if (ogrenci != null)
                    {
          
                        var ders = context.Dersler.FirstOrDefault(d => d.DersKod == dersKodu);

                        if (ders != null)
                        {
                     
                            var ogrenciDers = new StudentStudy
                            {
                                OgrenciId = ogrenci.OgrenciId,  
                                DersId = ders.DersId         
                            };

                      
                            context.StudentStudies.Add(ogrenciDers);
                            context.SaveChanges();

                            MessageBox.Show("Ders başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Ders bulunamadı.");
                        }
                    }
                    else
                    {
                        lblSecilenDersler.Text = "Lütfen bir satır seçin.";
                    }
                }

            }

        }
    }
}