using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicSunset.Data
{
    public class Drinks
    {
        public int id { get; set; } 
        public string drinkname { get; set; }
        public string drinkind { get; set; }
        public string description { get; set; }
        public int size { get; set; } 
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }  
        public Drink drinkkind { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
