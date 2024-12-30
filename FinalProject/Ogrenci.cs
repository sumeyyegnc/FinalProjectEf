using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Ogrenci
    {



        public int OgrenciId { get; set; }
        public ICollection<StudentStudy> StudentStudies { get; set; }


        public int SinifId { get; set; }
        public  Sinif Sinif { get; set; }



        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Numara { get; set; }




    }
}
