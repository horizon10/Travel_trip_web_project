﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelTripMVCProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; } 
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}
