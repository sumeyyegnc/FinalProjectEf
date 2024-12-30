using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class OgrenciEkleme : Form
    {

        private FinalDbContext dbContext;
        public OgrenciEkleme()
        {
            InitializeComponent();
            dbContext = new FinalDbContext();
        }

        private List<Sinif> siniflar = new List<Sinif>();


        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {


            using (var dbContext = new FinalDbContext())
            {
                var siniflar = dbContext.Siniflar
                                        .Select(s => new Sinif
                                        {
                                            SinifId = s.SinifId,
                                            SinifAd = s.SinifAd
                                        })
                                        .ToList();

                combobox_siniflar.DataSource = siniflar;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (textAd.Text == String.Empty || textSoyad.Text == String.Empty || textNumara.Text == string.Empty)
            {
                MessageBox.Show("Tüm alanlar zorunludur.");
                return;
            }

            var seciliSnf = (Sinif)combobox_siniflar.SelectedItem;
            int seciliSnfId = seciliSnf.SinifId;
            string Ad = textAd.Text;
            string Soyad = textSoyad.Text;
            string Numara = textNumara.Text;

            if (!int.TryParse(Numara, out _))
            {
                MessageBox.Show("Lütfen yalnızca tam sayı giriniz!");
                return;
            }


            using (var context = new FinalDbContext())
            {
                try
                {
                    if (KontenjanDoluluk(seciliSnfId))
                    {
                        var ogr = new Ogrenci();
                        ogr.Numara = Numara;
                        ogr.Ad = Ad;
                        ogr.Soyad = Soyad;
                        ogr.SinifId = seciliSnfId;
                        context.Ogrenciler.Add(ogr);
                        context.SaveChanges();

                        MessageBox.Show("Kullanıcı başarıyla kaydedildi."); 
                    }
                    else
                    {

                        MessageBox.Show("Sınıf Kontenjanı Dolu Başka bir sınıf seçiniz");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string Numara = textNumara.Text;


            if (int.TryParse(Numara, out int ogrenciNumara))
            {
                using (var context = new FinalDbContext())
                {

                    var ogrenci = context.Ogrenciler
                                         .FirstOrDefault(o => o.Numara == ogrenciNumara.ToString());

                    if (ogrenci != null)
                    {

                        textAd.Text = ogrenci.Ad;
                        textSoyad.Text = ogrenci.Soyad;
                    }
                    else
                    {

                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                }
            }

        }



        private void btnDersSecimi_Click(object sender, EventArgs e)
        {


            string Ad = textAd.Text;
            string Soyad = textSoyad.Text;
            string Numara = textNumara.Text;
            string SinifAdi = combobox_siniflar.SelectedItem.ToString();
            DersSecme dersSecme = new DersSecme(Ad, Soyad, Numara, SinifAdi);
            dersSecme.Show();
        }


        private bool KontenjanDoluluk(int sinifId)
        {
            using (var context = new FinalDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                var kontenjanDoluluk = context.Ogrenciler.Count(o => o.SinifId == sinifId);

                return kontenjanDoluluk >= int.Parse(sinif.SinifKontejan);
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string Numara = textNumara.Text;

            using (var context = new FinalDbContext())
            {
                var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == Numara);

                if (ogrenci != null)
                {
                    ogrenci.Ad = textAd.Text;
                    ogrenci.Soyad = textSoyad.Text;
                    var seciliSinif = (Sinif)combobox_siniflar.SelectedItem;
                    ogrenci.SinifId = seciliSinif.SinifId;


                    context.SaveChanges();

                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                }

                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }
        }
    }
}
