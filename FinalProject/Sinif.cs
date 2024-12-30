using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Sinif
    {
        public int SinifId { get; set; }


       
        public string SinifAd { get; set; }

       
        public string SinifKontejan { get; set; }

        public override string ToString()
        {
            return SinifAd;
        }

        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
