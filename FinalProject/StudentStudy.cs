using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class StudentStudy
    {

        public int DersId { get; set; }
        public int OgrenciId { get; set; }

        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
