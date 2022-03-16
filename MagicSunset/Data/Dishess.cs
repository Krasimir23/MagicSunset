﻿using System.Collections.Generic;

namespace MagicSunset.Data
{
    public class Dishess
    {
        public int id { get; set; } 
        public string dishname { get; set; }
        public string dishkind { get; set; }
        public string allergens { get; set; }   
        public int gram { get; set; }
        public double  price { get; set; }  
        
        public ICollection<Order> Orders { get; set; }  
    }
}
