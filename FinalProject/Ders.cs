﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Ders
    {

        public int DersId { get; set; }

        public string DersKod { get; set; }

   
        public string DersAd { get; set; }


        public ICollection <StudentStudy> StudentStudies {get; set;}
    }
}
