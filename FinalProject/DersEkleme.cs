using static System.Net.Mime.MediaTypeNames;

namespace FinalProject
{
    public partial class DersEkleme : Form
    {
        public DersEkleme()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (textDersAdi.Text == String.Empty || textDersKodu.Text == String.Empty)
            {
                MessageBox.Show("Tüm alanlar zorunludur.");
                return;
            }



            string DersAdi = textDersAdi.Text;
            string DersKodu = textDersKodu.Text;



            using (var context = new FinalDbContext())
            {
                try
                {
                    var drs = new Ders();
                    drs.DersAd = DersAdi;
                    drs.DersKod = DersKodu;

                    context.Dersler.Add(drs);
                    context.SaveChanges();

                    MessageBox.Show("Ders baþarýyla kaydedildi.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DersEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnÖðrenciEklemeFrm_Click(object sender, EventArgs e)
        {
            OgrenciEkleme ogrekleme = new OgrenciEkleme();
            ogrekleme.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string DersKodu = textDersKodu.Text;


            if (int.TryParse(DersKodu, out int ogrenciNumara))
            {
                using (var context = new FinalDbContext())
                {

                    var ders = context.Dersler
                                         .FirstOrDefault(d => d.DersKod == DersKodu.ToString());

                    if (ders != null)
                    {

                        textDersAdi.Text = ders.DersAd;
                    }
                    else
                    {

                        MessageBox.Show("Öðrenci bulunamadý!");
                    }
                }
            }

        }
    }
}
